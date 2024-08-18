namespace CsvDataAccess.NewSolution;

public class Row
{
    private Dictionary<string, string> _dataString = new();
    private Dictionary<string, int> _dataInt = new();
    private Dictionary<string, decimal> _dataDecimal = new();
    private Dictionary<string, bool> _dataBool = new();

    public void AssignCell (string columnName, bool value)
    {
        _dataBool[columnName] = value;
    }

    public void AssignCell(string columnName, int value)
    {
        _dataInt[columnName] = value;
    }

    public void AssignCell(string columnName, decimal value)
    {
        _dataDecimal[columnName] = value;
    }

    public void AssignCell(string columnName, string value)
    {
        _dataString[columnName] = value;
    }

    public object GetAtColumn(string columnName)
    {
        if (_dataBool.ContainsKey(columnName))
            return _dataBool[columnName];
        if (_dataInt.ContainsKey(columnName))
            return _dataInt[columnName];
        if (_dataDecimal.ContainsKey(columnName))
            return _dataDecimal[columnName];
        if (_dataString.ContainsKey(columnName))
            return _dataString[columnName];
        return null;
    }
}