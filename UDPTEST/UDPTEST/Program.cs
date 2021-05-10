using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.IO;

namespace UDPTEST
{
    class Program

    {
        public static string Msg = "0";
        static void Main(string[] args)
        {

            //Console.WriteLine("UDP TEST ...");
            //Creates a UdpClient for reading incoming data.
            
            
            UdpClient receivingUdpClient = new UdpClient(54000);
            //Console.WriteLine(receivingUdpClient);

            //Creates an IPEndPoint to record the IP Address and port number of the sender.
            // The IPEndPoint will allow you to read datagrams sent from any source.
            int y = 0;
            

            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (y < 1000)
            {
                try
                {
                    receivingUdpClient.Connect("172.20.10.5", 54000);
                    Byte[] sendBytes = Encoding.ASCII.GetBytes("Is anybody there?");
                    receivingUdpClient.Send(sendBytes, sendBytes.Length);
                    // Blocks until a message returns on this socket from a remote host.
                    Byte[] receiveBytes = receivingUdpClient.Receive(ref RemoteIpEndPoint);
                    //Console.WriteLine(receiveBytes.Length);
                    
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    

                    Console.WriteLine("This is the message you received : " +
                                              returnData.ToString());
                    Msg = returnData.ToString();
                    string writeText = Msg;  // Create a text string
                    File.WriteAllText("C:/Users/erram/OneDrive/Bureau/New Unity Project (1)/C#/ConsoleApp1/ConsoleApp1/filename.txt", writeText);  // Create a file and write the content of writeText to it
                    string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
                    Console.WriteLine("This message was sent from " +
                                                RemoteIpEndPoint.Address.ToString() +
                                                " on their port number " +
                                                RemoteIpEndPoint.Port.ToString());
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                y += 1;
            }
        }
    }
}
