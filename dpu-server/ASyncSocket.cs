using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.IO;
using System.Resources;

namespace dpu_server
{
    public struct fileDownloadSource_t
    {
        public string name;
        public string hostname;
        public string numericHostName; // Fallback
        public int port;
    }

    public class ConnState
    {
        public Socket workSocket = null;
        public const int recBufferSize = 1 << 20;
        public byte[] recBuffer = new byte[recBufferSize];
        public StringBuilder sb = new StringBuilder();
    }

    class ASyncSocket
    {
        private int port;
        private string ip;
        private Socket client;

        private IPAddress ipAddress;
        private IPEndPoint ipEndPoint;
        private ConnState state = new ConnState();

        public ASyncSocket(string ip_, int port_)
        {
            port = port_;
            ip = ip_;
        }

        public ManualResetEvent connectDone = new ManualResetEvent(false);
        public ManualResetEvent sendDone = new ManualResetEvent(false);
        public ManualResetEvent receiveDone = new ManualResetEvent(false);
        public ManualResetEvent allDone = new ManualResetEvent(false);

        public String response = String.Empty; // Server response
        public int RSS;

        public void StartClient()
        {
            try
            {
                ipAddress = IPAddress.Parse(ip);
                ipEndPoint = new IPEndPoint(ipAddress, port);

                client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                client.BeginConnect(ipEndPoint, new AsyncCallback(ConnectCallback), client);
                connectDone.WaitOne();
            }
            catch (Exception e) {  
                Console.WriteLine(e.ToString());  
            }
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                client.EndConnect(ar);
                connectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Receive()
        {
            try
            {
                // Set the workSocket.
                if (state.workSocket == null)
                {
                    state.workSocket = client;
                }

                // Begin receiving the data from the remote device.  
                client.BeginReceive(state.recBuffer, 0, ConnState.recBufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                receiveDone.WaitOne();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        // @TODO 
        // Optimize this and make sure we receive all data, if it is send in chunks
        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket   
                // from the asynchronous state object.  
                ConnState state = (ConnState)ar.AsyncState;
                Socket client = state.workSocket;

                // Read data from the remote device.  
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    //Console.WriteLine("Received : {0} bytes", bytesRead);
                    state.sb.Append(Encoding.ASCII.GetString(state.recBuffer, 0, bytesRead));

                    if (state.sb.Length > 1)
                    {
                        response = state.sb.ToString();
                        Int32.TryParse(response, out RSS);
                    }

                    // Signal that all bytes have been received.  
                    receiveDone.Set();
                    state.sb.Clear();
                    //client.BeginReceive(state.recBuffer, 0, ConnState.recBufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    if (state.sb.Length > 1)
                    {
                        response = state.sb.ToString();
                    }

                    // Signal that all bytes have been received.  
                    receiveDone.Set();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Send(String data)
        {
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.  
            client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), client);
            sendDone.WaitOne();
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket client = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = client.EndSend(ar);
                //Console.WriteLine("Sent {0} bytes to server.", bytesSent);

                // Signal that all bytes have been sent.  
                sendDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Shutdown(IAsyncResult ar)
        {
            client.Shutdown(SocketShutdown.Both);
            client.Close();
        }

    }
}
