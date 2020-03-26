using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Collections.Generic;
using System.Globalization;


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
            SEC test = new SEC();
            test.Cluster();

            /*ASyncSocket[] sockets = new ASyncSocket[NUM_SOURCES];
            List<int> RSSIList = new List<int>();

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
                    System.Console.Write("{0}, ", sockets[i].RSS);
                }

                // @TODO:
                // This is where we need to run the weighted k-nearest neighbors algorithm.
                // To do this we need, to gather all the sockets[i].RSS values into a list, that the algorithm
                // can then process. We do this every 250ms. -bjarke, 25th March 2020.
                

                System.Console.WriteLine("");
                Thread.Sleep(250);
            }
            */

            return 0;
        }
    }
}

