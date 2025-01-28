/*
 * AUTHOR: Ethan Schoonbee
 * CREATED: 27-01-2025
 * EDITED: 28-01-2025
 */

using System.Net.Sockets;
using System.Text;

namespace tcp_client;

/// <summary>
/// client to connect to the server on port 8888
/// and local host ip, and read a message from
/// the NetworkStream, convert to a string and
/// display in the console
/// </summary>
public class TCPClient
{
    public static void Main(string[] args)
    {
        /*
         * create a TcpClient object and connect to the server
         *  - on localhost (127.0.0.1)
         *  - on port 8888 (server's port)
         */
        TcpClient client = new TcpClient("127.0.0.1", 8888);
        
        // get the NetworkStream associated with the connection server to communicate with the server
        NetworkStream stream = client.GetStream();
        
        /*
         * read the message from the server
         *  - store in a byte[] with a size of 256 bytes
         *  - expect a message with a maximum size of 256 bytes
         *  - if the message is >256 bytes it would need to be handled differently
         */
        byte[] recievedData = new byte[256];
        
        /*
         * read the data send from the server in the NetworkStream ino the array
         *  - start at index 0
         *  - read up to the size of the byte[] (recievedData.Length)
         *  - returns the number of bytes actually read
         */
        int bytesRead = stream.Read(recievedData, 0, recievedData.Length);
        
        // convert the byte array message into a string and display it
        string message = Encoding.ASCII.GetString(recievedData, 0, bytesRead);
        
        // print the recieved message to the console
        Console.WriteLine("Message from server: {0}", message);
        
        // close the connection
        client.Close();
    }
}
//____________________________________....oooOO0_END_OF_FILE_0OOooo....____________________________________