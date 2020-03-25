using System;
using System.Collections.Generic;
using System.Text;

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



    #region Point Class

    // Point which consists of an X and Y coordinate
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int id { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    #endregion

    #region Knearest Algorithm

    public class Knearest
    {
        // Euclidean distance function (Two dimensional)
        // Returns the difference between the target point and points 
        private static double Distance(Point p1, Point p2)
        {
            if (p1.X < 0 || p1.Y < 0 || p2.X < 0 || p2.Y < 0)
            {
                throw new System.ArgumentException("Parameter cannot be below 0\n");
            }

            return Math.Sqrt((Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2)));
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

        // Classification: input sqrt(number of datapoints)

        // n = number of data points in the database, k = neighbours to the target, c = class/id.
        // PointArray = array of points in the database.
        // Target = target point to run the knearest on.
        public int WeightedKNN(Point[] PointArray, int k, Point Target, int c)
        {
            if (k < 1 || PointArray.Length > k)
            {
                throw new System.ArgumentException("Number of neighbours k cannot be below 1 or Array cannot be greater than the number of neighbours\n");
            }

            int N = PointArray.Length;
            double[] dist = new double[PointArray.Length]; // Distance array
            double[] w = new double[PointArray.Length]; // Weight array
            double[] classArray = new double[c]; // Class array

            for (int i = 0; i < PointArray.Length; i++)
            {
                dist[i] = (int)Distance(Target, PointArray[i]); // Distance is calculated and stored
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
                Point predictedpoint = PointArray[po];
                Console.WriteLine($" {predictedpoint.X} , {predictedpoint.Y}");
            }

            // predicting the class
            for (int i = 0; i < k; i++)
            {
                int corder = orderingArray[i];
                int predictedclass = PointArray[corder].id;
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
