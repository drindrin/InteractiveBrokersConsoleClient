//  --------------------------------------------------------------------------------------
// InteractiveBrokersConsoleClient.Program.cs
// 2016/12/12
//  --------------------------------------------------------------------------------------

using InteractiveBrokersConsoleClient.TwsApi;

namespace InteractiveBrokersConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TwsClient();
            client.ClientSocket.eConnect("", 0, 0);
            client.ClientSocket.startApi();
        }
    }
}