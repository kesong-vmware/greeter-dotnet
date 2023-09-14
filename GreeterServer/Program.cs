using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GreeterServer;

class Program
{
    static async Task Main(string[] args)
    {
        using var channel = GrpcChannel.ForAddress("https://localhost:5001");
        var client = new Greeter.GreeterClient(channel);

        var reply = await client.SayHelloAsync(
            new HelloRequest { Name = "World" });

        Console.WriteLine("Greeting: " + reply.Message);
    }
}