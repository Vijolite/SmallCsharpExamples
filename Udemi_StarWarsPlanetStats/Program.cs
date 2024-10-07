// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;
using System.Text.Json;


// https://swapi.dev/api/planets - SWAPI endpoint for getting the collection of planets
// https://swapi.dev/documentation#planets - description of planets data from the SWAPI documentation

var baseAddress = "https://swapi.dev/api/";
var requestUri = "planets";

IApiDataReader apiDataReader = new ApiDataReader();
var json = await apiDataReader.Read(baseAddress, requestUri);


var root = JsonSerializer.Deserialize<Root>(json);

foreach (var item in root.results)
{
    Console.WriteLine($"Planet = {item.name} Population = {item.population } creatures Diameter = {item.diameter} Surface = {item.surface_water}");
}
Console.ReadKey();

public interface IApiDataReader
{
    Task<string> Read(string baseAddress, string requestUri);
}

public class ApiDataReader : IApiDataReader
{
    public async Task<string> Read(string baseAddress, string requestUri)
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(baseAddress);
        var response = await client.GetAsync(requestUri);

        response.EnsureSuccessStatusCode(); //through exception if getting data from api is not possible

        return await response.Content.ReadAsStringAsync();
    }
}

public class Result
{
    public string name { get; set; }
    public string rotation_period { get; set; }
    public string orbital_period { get; set; }
    public string diameter { get; set; }
    public string climate { get; set; }
    public string gravity { get; set; }
    public string terrain { get; set; }
    public string surface_water { get; set; }
    public string population { get; set; }
    public List<string> residents { get; set; }
    public List<string> films { get; set; }
    public DateTime created { get; set; }
    public DateTime edited { get; set; }
    public string url { get; set; }
}

public class Root
{
    public int count { get; set; }
    public string next { get; set; }
    public object previous { get; set; }
    public List<Result> results { get; set; }
}