// See https://aka.ms/new-console-template for more information

using StackExchange.Redis;



try
{
    var options = ConfigurationOptions.Parse("3.85.129.153:6379"); // host1:port1, host2:port2, ...
    options.Password = "mypass";
    ConnectionMultiplexer conn = ConnectionMultiplexer.Connect(options);

    IDatabase database = conn.GetDatabase();

    database.StringSet("Key", "Value", TimeSpan.FromSeconds(60));
    var value = database.StringGet("Key");
    Console.WriteLine("Value cached in redis server is: " + value);
    Console.ReadLine();
}catch(Exception ex)
{
    Console.WriteLine("Can't connect");
}