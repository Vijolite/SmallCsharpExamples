public class TablePrinter <T>
{
    const int cellLength = 15;
    public List<T> Items { get; set; }

    public TablePrinter (List<T> items)
    {
        Items = items;
    }

    public void Print ()
    {
       PrintTopLine();
       PrintData();
    }

    private void PrintTopLine()
    {
        List<string> columnNames = new List<string>();
        string topLine = "";
        string borderLine = "";
        string borderFragment = new string('-', cellLength);
        foreach (var property in Items[0].GetType().GetProperties())
        {
            topLine += $"{property.Name,cellLength} |";
            borderLine += $"{borderFragment} |";
        }
        Console.WriteLine(topLine);
        Console.WriteLine(borderLine);

    }

    private void PrintData()
    {
        foreach (var item in Items)
        {
            string dataLine = "";
            foreach (var property in item.GetType().GetProperties())
            {
                dataLine += $"{property.GetValue(item),cellLength} |";
            }
            Console.WriteLine(dataLine);
        }
    }
}
