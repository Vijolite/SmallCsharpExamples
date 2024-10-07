using System.Dynamic;
using System.Reflection;
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
    Console.WriteLine($"Planet = {item.name} Population = {item.population }  Diameter = {item.diameter} SurfaceWater = {item.surface_water}");
}

var tablePrinter = new TablePrinter(MyConverter<Result>.ConvertToObjectList(root.results));
var columnNames = tablePrinter.GetColumnNames();

foreach (var cN in columnNames)
{
    Console.WriteLine(cN);
}


Console.ReadKey();


public class TablePrinter
{
    public List<object> Items { get; set; }

    public TablePrinter (List<object> items)
    {
        Items = items;
    }

/*    public void Print ()
    {
        string topLine = "";
        foreach (var columnName in ColumnNames)
        {
            topLine += $"{0,10} {columnName}";
        }
        Console.WriteLine(topLine);
    }*/

    public List<string> GetColumnNames()
    {
        List<string> columnNames = new List<string>();
        foreach (var property in Items[0].GetType().GetProperties())
        {
            columnNames.Add(property.Name);
        }
        return columnNames;
    }
}

public static class MyConverter <T>
{
    public static System.Collections.Generic.List<object> ConvertToObjectList (List<T> listToConvert)
    {
        var objectList = new List<object>();
        foreach (var item in listToConvert)
        {
            objectList.Add(item);
        }
        return objectList;

    }
}
