using System;
using System.Collections.Generic;
using System.Text;
using dpu_server.ServiceLayer.Services;
using dpu_server.Knearest;
using dpu_server.DataLayer.Repositories;
using System.Threading.Tasks;

namespace dpu_server
{
    class SEC
    {
        private static double EPS = 1e-8;
        private int numberOfReferencePoints;
        private int k;
        private List<Point2D> points = new List<Point2D>();
        private List<Point2D>[] clusters;
        private Circle2D[] centroids;
        private static ReferencepointService referencepointService;
        private List<Models.Referencepoint> Tuples;

        public async Task GetAllPoints()
        {
            Tuples = await referencepointService.GetAllAsync();
            foreach(var t in Tuples)
            {
                Point2D p = new Point2D(t.X, t.Y);
                p.id = t.ReferencepointId - 1; // The tuples are not zero indexed so minus their id by 1.
                points.Add(p);
            }
 
            numberOfReferencePoints = Tuples.Count;
            k = (int)Math.Sqrt(numberOfReferencePoints);
        }

        public void UpdateCategories(List<Point2D>[] clusters)
        {
            foreach (var clusterOfPoints in clusters)
            {
                foreach (var p in clusterOfPoints)
                {
                    Tuples[p.id].Category = p.classification;
                    referencepointService.UpdateAsync(Tuples[p.id]).Wait();
                }
            }
        }

        public SEC()
        {
            referencepointService = new ReferencepointService(new ReferencepointRepository(new FruitFlyContext()));
            GetAllPoints().Wait();

            // Make the clusters
            clusters = new List<Point2D>[k];
            centroids = new Circle2D[k];

            // Select k points from points and set them as centroids.
            // Also create the clusters
            for(int i = 0; i < k; i++)
            {
                clusters[i] = new List<Point2D>();
                centroids[i] = new Circle2D(new Point2D(0, 0), 0);

                // @TODO make the point selection random
                // Create the center of the SEC.
                centroids[i].p.x = points[i].x;
                centroids[i].p.y = points[i].y;
            }
        }

        // This is where the clustering gets done.
        public void Cluster()
        {
            Circle2D[] previousCentroids = new Circle2D[k];
            Array.Copy(centroids, previousCentroids, centroids.Length);

            // Calculate the distance of the remaining points and
            // cluster them into the SEC. Based on the minimum-distance principle.
            for (int i = 0; i < numberOfReferencePoints; i++)
            {
                double oldDistance = Int32.MaxValue;
                double newDistance = 0;
                int clusterIndex = 0;

                for (int j = 0; j < k; ++j)
                {
                    newDistance = distance(points[i].x, centroids[j].p.x, points[i].y, centroids[j].p.y);

                    // If the new distance is smaller than the others we have seen
                    // update the distance and the cluster.
                    if (newDistance <= oldDistance)
                    {
                        oldDistance = newDistance;
                        clusterIndex = j;
                    }
                }

                points[i].classification = clusterIndex; // This is the cluster where the point resides
                clusters[clusterIndex].Add(points[i]);
            }

            // Perform the SmallestEnclosingCircle algorithm on our current clusters
            for (int i = 0; i < k; i++)
            {
                SmallestEnclosingCircle(ref clusters[i], ref centroids[i]);
            }

            // @Note:
            // Debugging only
            System.Console.WriteLine("Smallest Enclosing Cirlce (SEC) Complete: ");
            System.Console.WriteLine("");
            for (int i = 0; i < k; i++)
            {
                System.Console.WriteLine("      ({0},{1}), {2}", centroids[i].p.x, centroids[i].p.y, centroids[i].radius);
            }

            // Now we need to decide if the algorithm has to run again.
            // @TODO:
            // Implement some kind of threshhold definition.
            // Right now we just see if the previous centroid is the same as the current one,
            // we could see if the radius decrease is smaller than something.. -bjarke, 21th March 2020.
            int numberOfEquals = 0;
            for (int i = 0; i < k; i++)
            {
                if (previousCentroids[i].p == centroids[i].p)
                {
                    numberOfEquals++;
                }
            }

            if (numberOfEquals == k)
            {
                // @TODO:
                // Entering this if-statement, means that the clustering is done. Now we have to insert
                // each point back into the database, along with their classification (clusterIndex).
                // Furthermore we will add the centroid center coordinates to the database. 
                UpdateCategories(clusters);

                return; // SEC is done
            }

            // If the algorithm isn't done yet, clear the clusters and redo the clustering.
            for(int i = 0; i < k; i++)
            {
                clusters[i].Clear();
            }

            Array.Copy(centroids, previousCentroids, centroids.Length);
        }

        public static double distance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        }

        public static Point2D bary(in Point2D A, in Point2D B, in Point2D C, double a, double b, double c)
        {
            return (A * a + B * b + C * c) / (a + b + c);
        }
        public static Point2D circumcenter(in Point2D A, in Point2D B, in Point2D C)
        {
            double a = (B - C).norm2();
            double b = (C - A).norm2();
            double c = (A - B).norm2();

            return bary(A, B, C, a * (b + c - a), b * (c + a - b), c * (a + b - c));
        }

        public static void SmallestEnclosingCircle(ref List<Point2D> P, ref Circle2D center) {
            P.Shuffle();
            double N = P.Count;

            center.radius = 0;
            for(int i = 0; i < N; ++i)
            {
                if((P[i] - center.p).norm() > center.radius + EPS)
                {
                    center.p = P[i];
                    center.radius = 0;
                    for(int j = 0; j < i; ++j)
                    {
                        if((P[j] - center.p).norm() > center.radius + EPS)
                        {
                            center.p = (P[i] + P[j]) / 2;
                            center.radius = (P[i] - center.p).norm();
                            for(int k = 0; k < j; ++k)
                            {
                                if((P[k] - center.p).norm() > center.radius + EPS)
                                {
                                    center.p = circumcenter(P[i], P[j], P[k]);
                                    center.radius = (P[k] - center.p).norm();
                                }
                            }
                        }
                    }
                }
            }
        }

    }

    // We use this extension to shuffle our lists of points.
    static class MyExtension
    {
        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
