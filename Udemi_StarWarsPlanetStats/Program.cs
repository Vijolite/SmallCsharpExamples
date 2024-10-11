using System.Text.Json;
using Udemi_StarWarsPlanetStats.Model;
using Udemi_StarWarsPlanetStats.UserInputOutput;


// https://swapi.dev/api/planets - SWAPI endpoint for getting the collection of planets
// https://swapi.dev/documentation#planets - description of planets data from the SWAPI documentation

var baseAddress = "https://swapi.dev/api/";
var requestUri = "planets";

IApiDataReader apiDataReader = new ApiDataReader();
var json = await apiDataReader.Read(baseAddress, requestUri);


var root = JsonSerializer.Deserialize<Root>(json);

var planets = root.Extract();

var tablePrinter = new TablePrinter<Planet>(planets);
tablePrinter.Print();

var tableCalculator = new TableCalculator<Planet>(planets);
var userChoice = UserChoice.GetChoise();
Tuple<long, Planet> result = tableCalculator.FinMaxInColumn(userChoice);
Console.WriteLine(result.Item1);

Console.ReadKey();

