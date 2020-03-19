using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using dpu_server.Models;

namespace dpu_server
{
    public class SynchronousSocketClient
    {

        public static void StartClient()
        {
            // Data buffer for incoming data.  
            byte[] bytes = new byte[1024];

            // Connect to a remote device.  
            try
            {
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                //IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = IPAddress.Parse("192.168.88.128");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 27015);

                // Create a TCP/IP  socket.  
                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes("PWD");

                    // Send the data through the socket.  
                    int bytesSent = sender.Send(msg);

                    // Receive the response from the remote device.  
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("{0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    // Release the socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static int Main(String[] args)
        {
            //StartClient();

            string filepath = @"C:\Users\mongl\data.txt";

            List<string> lines = File.ReadAllLines(filepath).ToList();
            var lineCount = File.ReadLines(filepath).Count();

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            using (var FFContext = new MyDbContext())
            {

                string[] entries = { "0" };

                // Splitting the lines
                foreach (var line in lines)
                {
                    entries = line.Split(',');
                }


                var referencepoint = new Referencepoint
                {
                    X = int.Parse(entries[0]),
                    Y = int.Parse(entries[1]),
                    RSSI1 = int.Parse(entries[2]),
                    RSSI2 = int.Parse(entries[3]),
                    RSSI3 = int.Parse(entries[4]),
                };

                var Heatmapinstance = new Heatmap
                {
                    Strength = 1,
                    X = referencepoint.X,
                    Y = referencepoint.Y,
                };

                FFContext.Heatmaps.Add(Heatmapinstance);
                FFContext.Referencepoints.Add(referencepoint);
                FFContext.SaveChanges();
            }
            return 0;
        }
    }
}

