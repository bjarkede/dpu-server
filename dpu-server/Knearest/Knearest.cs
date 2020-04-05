using dpu_server.ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dpu_server.Knearest
{


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("-- Weighted KNN test --\n");

    //        Console.WriteLine("Number of neighbours; k = 5\n");
    //        Console.WriteLine("Target point: ( 5 , 5 )\n\n");
    //        Knearest kn = new Knearest();

    //        Point[] parray = new Point[5]
    //            {new Point(1, 1), new Point(2, 2), new Point(3, 3), new Point(4, 4), new Point(5, 5)};

    //        Point target = new Point(2, 2);

    //        kn.WeightedKNN(parray, 5, target, 3);

    //    }
    //}


    #region Knearest Algorithm

    public class Knearest
    {

        private static ReferencepointService referencepointService;
        List<Tuple<List<int>, int>> rssiData;

        // Euclidean distance function (Two dimensional)
        private static double Distance(List<int> l1, List<int> l2)
        {
            double result = 0;
            for (int i = 0; i < l1.Count; i++)
            {
                result += Math.Pow(l1[i] - l2[i], 2);
            }
            return Math.Sqrt(result);
        }

        // Weight function to generate weights for points
        // Inverse method
        private static double[] Weights(int k, double[] distances) // Closest in terms of distance = highest weight
        {
            if (k < 1)
            {
                throw new System.ArgumentException("Number of neighbours K cannot be below 1\n");
            }

            double[] Weights = new double[k]; // defines one weight per neighbour

            for (int i = 0; i < k; i++) // Generating weights for all neighbours
            {
                Weights[i] = 1 / distances[i]; // Formular:  w_i = 1/d_i
            }

            return Weights;
        }

        public async Task getAllRssiData()
        {
            var Tuples = await referencepointService.GetAllAsync();
            foreach (var t in Tuples)
            {
                rssiData.Add(Tuple.Create(new List<int> { t.RSSI1, t.RSSI2, t.RSSI3 }, t.Category));
            }
        }

        public Knearest()
        {
            getAllRssiData().Wait();
        }

        // Classification: input sqrt(number of datapoints)

        // rssivalues is all the rssi values in the database.
        // c is the catogory of the rssi values. Cluster ID
        // k is the number of neighbours.
        public int WeightedKNN(int k, List<int> rssivalues, int c)
        {
            if (k < 1 || rssiData.Count > k)
            {
                throw new System.ArgumentException("Number of neighbours k cannot be below 1 or Array cannot be greater than the number of neighbours\n");
            }

            int N = rssiData.Count;
            double[] dist = new double[N]; // Distance array
            double[] w = new double[N]; // Weight array
            double[] classArray = new double[c]; // Class array

            for (int i = 0; i < N; i++)
            {
                dist[i] = Distance(rssivalues, rssiData[i].Item1); // Distance is calculated and stored
            }

            // Ordering the array
            int[] orderingArray = new int[N];

            for (int i = 0; i < N; ++i)
            {
                orderingArray[i] = i;
            }
            double[] distancesCopy = new double[N]; // Creating a copy of the dist array
            Array.Copy(dist, distancesCopy, dist.Length);
            Array.Sort(distancesCopy, orderingArray);   // Storing dist values in the copied array
                                                        // and sorting the copied array so the original array remains.

            // Printing distances out
            for (int i = 0; i < k; ++i)
            {
                int p = orderingArray[i];
                Console.WriteLine("  distance = " + distancesCopy[p].ToString("F4"));
            }

            // Weights
            w = Weights(k, dist);

            // Printing Weights
            Console.WriteLine("\nWeights: ");
            for (int i = 0; i < w.Length; ++i)
            {
                Console.Write(w[i].ToString("F4") + "  ");
            }

            Console.WriteLine("\n\nPredicted Point has the weight: ");

            for (int i = 0; i < k; i++)
            {
                int pw = orderingArray[i];
                double _w = w[pw];
                Console.WriteLine($" {_w}");
            }

            Console.WriteLine("\n\nClosest point starting from the top:  ");
            for (int i = 0; i < k; ++i)
            {
                int po = orderingArray[i];
                List<int> predictedrssi = rssiData[po].Item1;
                foreach (var item in predictedrssi)
                {
                    Console.Write("{0},", item);
                }
                Console.WriteLine("");
            }

            // predicting the class
            for (int i = 0; i < k; i++)
            {
                int corder = orderingArray[i];
                int predictedclass = rssiData[corder].Item2;
                classArray[predictedclass] += w[i];
            }

            // printing the class inorder
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("(" + i + ") " + classArray[i].ToString("F4"));
            }

            // should return the point and a weight (incremental value based on)

            return 0;

        }


    }

    #endregion

}
