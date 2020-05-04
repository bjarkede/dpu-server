using dpu_server.DataLayer.Repositories;
using dpu_server.ServiceLayer.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpu_server.Knearest
{
    public class Knearest
    {
        private int numberOfClusters;
        private static ReferencepointService referencepointService;
        private static HeatmapService heatmapService;
        List<Tuple<List<int>, int, int>> rssiData = new List<Tuple<List<int>, int, int>>();

        // Euclidean distance function (Two dimensional)
        private static Tuple<double, int, int> Distance(List<int> l1, Tuple<List<int>, int, int> l2)
        {
            double result = 0;
            for (int i = 0; i < l1.Count; i++)
            {
                result += Math.Pow(l1[i] - l2.Item1[i], 2);
            }
            return Tuple.Create(Math.Sqrt(result), l2.Item2, l2.Item3);
        }

        // Weight function to generate weights for points
        // Inverse method
        private static List<Tuple<double, int, int>> Weights(int k, List<Tuple<double, int, int>> dist) // Closest in terms of distance = highest weight
        {
            if (k < 1)
            {
                throw new System.ArgumentException("Number of neighbours K cannot be below 1\n");
            }

            var Weights = new List<Tuple<double, int, int>>(); // defines one weight per neighbour

            for (int i = 0; i < k; i++) // Generating weights for all neighbours
            {
                Weights.Add(Tuple.Create(1 / dist[i].Item1, dist[i].Item2, dist[i].Item3)); // Formular:  w_i = 1/d_i
            }

            return Weights;
        }

        public async Task getAllRssiData()
        {
            var Tuples = await referencepointService.GetAllAsync();
            foreach (var t in Tuples)
            {
                rssiData.Add(Tuple.Create(new List<int> { t.RSSI1, t.RSSI2, t.RSSI3 }, t.Category, t.ReferencepointId));
            }

            numberOfClusters = (int)Math.Sqrt(Tuples.Count);
        }

        public async Task<Models.Referencepoint> GetPointByID(int id)
        {
            Models.Referencepoint tuple = await referencepointService.GetByIdAsync(id);

            return tuple;
        }

        public async Task addHeatmapData(int id)
        {
            Models.Heatmap heatmap = new Models.Heatmap();
            heatmap.ReferencepointId = id;
            await heatmapService.AddAsync(heatmap);
        }

        public async Task<string> ShowClosestPoint(int id)
        {
            var tuple = await GetPointByID(id);
            string ret = $"Closest Point is: {tuple.X}, {tuple.Y}";
            return ret;
        }

        public Knearest()
        {
            referencepointService = new ReferencepointService(new ReferencepointRepository(new FruitFlyContext()));
            heatmapService = new HeatmapService(new HeatmapRepository(new FruitFlyContext()));
            getAllRssiData().Wait();
        }

        // Classification: input sqrt(number of datapoints)

        // rssivalues is all the rssi values in the database.
        // c is the catogory of the rssi values. Cluster ID
        // k is the number of neighbours.
        public int WeightedKNN(int k, List<int> rssivalues)
        {
            if (k < 1)
            {
                throw new System.ArgumentException("Number of neighbours k cannot be below 1 or Array cannot be greater than the number of neighbours\n");
            }

            int N = rssiData.Count;
            var dist = new List<Tuple<double, int, int>>(); // Distance array
            var w = new List<Tuple<double, int, int>>(); // Weight array
            double[] classArray = new double[numberOfClusters]; // Class array
            IDictionary<int, double> dict = new Dictionary<int, double>();

            for (int i = 0; i < N; i++)
            {
                dist.Add(Distance(rssivalues, rssiData[i])); // Distance is calculated and stored
            }

            var sorted = dist.OrderBy(d => d.Item1);

            w = Weights(k, sorted.ToList());

            // Now we want to predict the class we belong to
            for (int i = 0; i < k; i++)
            {
                try
                {
                    dict.Add(w[i].Item2, w[i].Item1);
                } catch (ArgumentException)
                {
                    dict[w[i].Item2] += w[i].Item1;
                }
            }

            var keyOfMaxValue = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            var maxValue = dict.Values.Max();

            double greatestSoFar = 0;
            int index = 0;

            for(int i = 0; i < k; i++)
            {
                if(w[i].Item1 > greatestSoFar && 
                   w[i].Item2 == keyOfMaxValue)
                {
                    greatestSoFar = w[i].Item1;
                    index = w[i].Item3;
                }
            }

            //Console.WriteLine(ShowClosestPoint(index).Result);

            addHeatmapData(index).Wait();

            return 0;
        }
       
    }
}
