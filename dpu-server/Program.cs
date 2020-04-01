using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace dpu_server
{
    class Program
    {
        private static int NUM_SOURCES = 3;

        // Declare all sniffers in this array of structs
        private static fileDownloadSource_t[] fileDLSources =
        {
            new fileDownloadSource_t {name = "SNF1", hostname = "", numericHostName = "192.168.208.132", port = 27015},
        };

        public static int Main(String[] args)
        {
            //SEC test = new SEC();
            //test.Cluster();

            ASyncSocket[] sockets = new ASyncSocket[NUM_SOURCES];
            List<List<int>> RSSIList = new List<List<int>>();
            IDictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < NUM_SOURCES; i++)
            {
                ASyncSocket s = new ASyncSocket(fileDLSources[0].numericHostName, fileDLSources[0].port);
                sockets[i] = s;
                s.StartClient();
            }
            
            while (true)
            {
                for (int i = 0; i < NUM_SOURCES; i++)
                {
                    sockets[i].Send("RETR test.txt");
                    sockets[i].Receive();

                    // Split each dns:rssi into an item and add it to the dictionary.
                    for (int j = 0; j < sockets[i].response.Length; j++)
                    {
                        var item = sockets[i].response[j].Split(":");
                        try
                        {
                            dict.Add(item[0], new List<string>() { item[1] });
                        } catch (ArgumentException)
                        {
                            //Key already exits in the dict so append it to the list
                            dict[item[0]].Add(item[1]);
                        }
                    }
                }

                // @TODO:
                // This is where we need to run the weighted k-nearest neighbors algorithm.
                // To do this we need, to gather all the sockets[i].RSS values into a list, that the algorithm
                // can then process. We do this every 250ms. -bjarke, 25th March 2020.
                
                // Make the list of RSSI values.
                foreach (KeyValuePair<string, List<string>> p in dict)
                {
                    RSSIList.Add(p.Value.Select(int.Parse).ToList());
                }

                System.Console.WriteLine("");
                Thread.Sleep(250);
            }

            // Below is for testing.
            /*List<string[]> list = new List<string[]>();

            list.Add("7.192.163.51:88,199.187.194.244:56,6.38.202.48:100".Split(","));
            list.Add("7.192.163.51:34,199.187.194.244:23,6.38.202.48:24".Split(","));
            list.Add("7.192.163.51:78,199.187.194.244:67,6.38.202.48:53".Split(","));

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    var item = list[i][j].Split(":");
                    try
                    {
                        dict.Add(item[0], new List<string>() { item[1] });
                    } catch (ArgumentException)
                    {
                        //Key already exits in the dict
                        dict[item[0]].Add(item[1]);
                    }
                }
            }

            foreach(KeyValuePair<string, List<string>> p in dict) {
                RSSIList.Add(p.Value.Select(int.Parse).ToList());
            }
        
            foreach(var l in RSSIList)
            {
                foreach(int i in l)
                {
                    System.Console.WriteLine("{0}", i);
                }
            }*/
            
            return 0;
        }
    }
}

