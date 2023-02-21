// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Caching.Distributed;
using StackExchange.Redis;
using System.Text.Json;



try
{
    ConnectionMultiplexer conn = ConnectionMultiplexer.Connect("localhost");
    IDatabase database = conn.GetDatabase();
    database.StringSet("redisKey", "redisvalue");
    var value = database.StringGet("redisKey");
    Console.WriteLine("Value cached in redis server is: " + value);
    Console.ReadLine();
}catch(Exception ex)
{
    Console.WriteLine("Can't connect");
}
