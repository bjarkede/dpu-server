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
        // Declare all sniffers in this array of structs
        public static fileDownloadSource_t[] fileDLSources =
        {
            new fileDownloadSource_t {name = "SNF1", hostname = "", numericHostName = "192.168.86.157", port = 27015}
        };

        public static void ClientThread()
        {
            ASyncSocket Socket = new ASyncSocket(fileDLSources[0].numericHostName, fileDLSources[0].port);
            Socket.StartClient();

            while (true)
            {
                Socket.Send("RETR test.txt"); // Insert destination to char-driver
                Socket.Receive();

                Thread.Sleep(1000);
            }

            Socket.Shutdown();
        }

        public static int Main(String[] args)
        {
            ThreadStart Socket = new ThreadStart(ClientThread);
            Thread cliThread1 = new Thread(ClientThread);
            cliThread1.Start();

            while (true)
            {

            }

            return 0;
        }
    }
}

