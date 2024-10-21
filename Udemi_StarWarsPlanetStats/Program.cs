using System.Data;
using System.Text.Json;
using Udemi_StarWarsPlanetStats.Dto;
using Udemi_StarWarsPlanetStats.Model;
using Udemi_StarWarsPlanetStats.UserInputOutput;


// https://swapi.dev/api/planets - SWAPI endpoint for getting the collection of planets
// https://swapi.dev/documentation#planets - description of planets data from the SWAPI documentation

var baseAddress = "https://swapi33.dev/api/";
var requestUri = "planets";
var json = "";
IApiDataReader _apiDataReader;
try
{
    _apiDataReader = new ApiDataReader();
    json = await _apiDataReader.Read(baseAddress, requestUri);

}
catch (Exception ex)
{
    Console.WriteLine("An error occured. Exception message: " + ex.Message);
    Console.WriteLine("Using Mock data instead ...");
    _apiDataReader = new MockDataReader();
    json = await _apiDataReader.Read(baseAddress, requestUri);
}


var root = JsonSerializer.Deserialize<Root>(json);

var planets = root.Extract();
var planetsWithResidents = root.ExtractWithResidents(_apiDataReader);

var tablePrinter = new TablePrinter<Planet>(planets);
tablePrinter.Print();

ResidentsPrinter.Print(planetsWithResidents);

var tableCalculator = new TableCalculator<Planet>(planets);
var userChoice = UserChoice.GetChoise();
Tuple<long, Planet> resultMax = tableCalculator.FinMaxInColumn(userChoice);
Console.WriteLine($"Max {userChoice} is {resultMax.Item1} (planet:{resultMax.Item2.Name})");
Tuple<long, Planet> resultMin = tableCalculator.FinMinInColumn(userChoice);
Console.WriteLine($"Min {userChoice} is {resultMin.Item1} (planet:{resultMin.Item2.Name})");



Console.ReadKey();

