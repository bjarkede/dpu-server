﻿using System;
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
                // Request the file containing data on each ip and their received signal strength to the sniffer.
                for (int i = 0; i < NUM_SOURCES; i++)
                {
                    sockets[i].Send("RETR test.txt");
                    sockets[i].Receive();

                    // @Speed:
                    // Could probably make the code below take less time/use
                    // less memory - bjarke, 1st april 2020.
                    for (int j = 0; j < sockets[i].response.Length; j++)
                    {
                        var item = sockets[i].response[j].Split(":");
                        try
                        {
                            // Try adding the ip as a key, into the dictionary.
                            // If succesful, create the list containing the received signal strength values
                            dict.Add(item[0], new List<string>() { item[1] });
                        } catch (ArgumentException)
                        {
                            // If the key already exist in the dictionary, we add the new rssi value
                            // to the list linked to that key.
                            dict[item[0]].Add(item[1]);
                        }
                    }
                }
                
                // Make the list of RSSI values.
                foreach (KeyValuePair<string, List<string>> p in dict)
                {
                    RSSIList.Add(p.Value.Select(int.Parse).ToList());
                }

                Thread.Sleep(250);
            }
            
            return 0;
        }
    }
}

