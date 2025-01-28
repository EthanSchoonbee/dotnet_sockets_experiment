/*
 * AUTHOR: Ethan Schoonbee
 * CREATED: 27-01-2025
 * EDITED: 28-01-2025
 */

using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Console;

namespace tcp_server;

/// <summary>
/// server to listen for clients connections over TCP,
/// establishing a connection and a network stream,
/// and sending the client a message
/// </summary>
class TCPServer
{
    static void Main(string[] args)
    {
        /*
         * create a TCP/IP socket
         *  - listen to any ip
         *  - listen to PORT 8888
         */
        TcpListener server = new TcpListener(IPAddress.Any, 8888);
        
        // start listening for client requests
        server.Start();
        WriteLine("Server is listening on port 8888...");
        
        /*
         * loop to:
         *  - wait for client requests
         *  - establish a client connection
         *  - get the NetworkStream between the client and server for r/w over the TCP connection
         *  - convert a message string to byte[] using ASCII encoding to send it over the network
         *  - send the message using the NetworkStream to the client
         *      > starting at position 0
         *      > sending the number of bytes of the message (byte[].Length)
         *  - close the client-server connection and continue listening for more client connection requests
         */
        while (true)
        {
            /*
             * wait(block) until a client tries to connect to the server
             * when a connection is established a TcpClient object is returned
             */
            TcpClient client = server.AcceptTcpClient();
            WriteLine("Client connected.");
            
            // get the network stream to communicate with the client
            NetworkStream stream = client.GetStream();
            
            // send a message to the client
            byte[] message = Encoding.ASCII.GetBytes("Hello form the server!");
            stream.Write(message, 0, message.Length);
            WriteLine("Message sent to the client!");
            
            // close the connection
            client.Close();
        }
    }
}
//____________________________________....oooOO0_END_OF_FILE_0OOooo....____________________________________