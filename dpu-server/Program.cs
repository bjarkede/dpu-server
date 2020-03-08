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
            Socket.StartClient();

            // Send a test
            Socket.Send("LIST");
            Socket.sendDone.WaitOne();

            bool Running = true;

            while(Running)
            {
                Socket.Receive();
                Socket.receiveDone.WaitOne();

                Console.WriteLine("Response received : {0}", Socket.response);
                Running = false;
            }

            Socket.Shutdown();

            return 0;
        }
    }
}

