//  --------------------------------------------------------------------------------------
// InteractiveBrokersConsoleClient.Program.cs
// 2016/12/12
//  --------------------------------------------------------------------------------------

using System;
using InteractiveBrokersConsoleClient.TwsApi;

namespace InteractiveBrokersConsoleClient
{
    class Program
    {
        static TwsClient client;

        static void ConnectToTws()
        {
            client.ClientSocket.eConnect("127.0.0.1", 7496, 0, false);
        }

        static void DisconnectFromClient()
        {
            // Disconnect from the client once we're done
            Console.WriteLine("Disconnecting...");
            client.ClientSocket.eDisconnect();
        }

        static void GetCurrentTime()
        {
            client.ClientSocket.reqCurrentTime();
        }

        // Application entry point
        static void Main(string[] args)
        {
            client = new TwsClient();

            Console.WriteLine("Connecting...");
            // Connect to the Trader Workstation client
            ConnectToTws();
            WaitForConnection();

            // Now we can do whatever we want
            Console.WriteLine("Please enter a ticker symbol");
            GetCurrentTime();
            // We will implement ticker feed functionality once we
            // have the basic application working.
            //
            // var symbol = Console.ReadLine();
            // SubscribeToTickerFeed(symbol);

            DisconnectFromClient();
            Console.WriteLine("Finished.");
        }

        // TODO:  Implement this method
        //static void SubscribeToTickerFeed(string symbol)
        //{
        //    client.ClientSocket.reqMarketDataType(2);
        //}

        static void WaitForConnection()
        {
            // [From IBSamples.Program.cs]
            /*************************************************************************************************************************************************/
            /* One good way of knowing if we can proceed is by monitoring the order's nextValidId reception which comes down automatically after connecting. */
            /*************************************************************************************************************************************************/
            while (client.NextOrderId <= 0)
            {
                // Do nothing, we're waiting for a connection to happen.
            }
        }
    }
}