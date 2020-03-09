using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Collections.Generic;

namespace dpu_server
{

    class Program
    {
        public static int Main(String[] args)
        {
            ASyncSocket Socket = new ASyncSocket("192.168.88.130", 27015);

            // Send a test
            while (true)
            {
                Socket.StartClient();
                Socket.Send("RETR hello2.txt");
                Socket.Receive();

                Console.WriteLine("Response received : {0}", Socket.response);

                Socket.Shutdown();
            }

            

            return 0;
        }
    }
}

