// See https://aka.ms/new-console-template for more information


using System.Text.Json;


IDistributedCache _cache = new IDistributedCache();

var cacheKey = "Clientes";
string json = string.Empty;
json = JsonSerializer.Serialize<List<string>>(null);
await _cache.SetStringAsync(cacheKey, json);

await _cache.SetStringAsync(cacheKey, json);