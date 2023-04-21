using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class Server
    {
        Socket socket;
        internal static List<NetworkStream> clients = new List<NetworkStream>();

        public bool StartServer() {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 10000);
                socket.Bind(ep);

                Thread thread = new Thread(ListenUp);
                thread.IsBackground = true;
                thread.Start();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private void ListenUp()
        {
            try
            {
                while (true)
                {
                    socket.Listen(8);
                    Socket client = socket.Accept();
                    NetworkStream stream = new NetworkStream(client);
                    new ThreadClient(stream);

                    clients.Add(stream);
                }
            }
            catch (Exception)
            {

                //throw;
            }
        }

        internal bool StopServer()
        {
            try
            {
                socket.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            //Server s = new Server();
            //s.StartServer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ServerForm());
            Console.WriteLine("The server started successfully!");
        }
    }
}
