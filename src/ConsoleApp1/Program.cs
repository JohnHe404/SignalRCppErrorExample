using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task running()
        {
            var connection = new HubConnectionBuilder().WithUrl("https://localhost:44357/chathub").Build();
            await connection.StartAsync();
            Console.WriteLine("client connection state:" + connection.State);
            await connection.StopAsync();
            await connection.DisposeAsync();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                Console.WriteLine("input yes or no:");
                string input = Console.ReadLine();
                if (input.ToUpper().IndexOf("Y") != -1)
                {
                    Console.WriteLine("Ok! running... ...");
                    running().Wait();
                    continue;
                }
                else if (input.ToUpper().IndexOf("N") != -1)
                {
                    Console.WriteLine("So, break!");
                    break;
                }
                else
                {
                    Console.WriteLine("So, next!");
                }
            }
        }
    }
}
