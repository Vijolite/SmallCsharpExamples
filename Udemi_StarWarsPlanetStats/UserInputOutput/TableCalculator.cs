public class TableCalculator<T>
{
    public List<T> Items { get; set; }

    public TableCalculator(List<T> items)
    {
        Items = items;
    }

    public Tuple<long,T> FinMaxInColumn (string columnName)
    {
        var listOfValues = new List<int>();
        long maxValue = 0;
        T itemWithMaxValue = default(T);
        foreach (var item in Items)
        {
            var property = item.GetType().GetProperties().Where (x => x.Name == columnName).FirstOrDefault();
            var value = property?.GetValue(item);
            Console.WriteLine(value);
            if (value != null)
            {
                if ((long)value > maxValue)
                {
                    maxValue = (long)value!;
                    itemWithMaxValue = item;
                }
            }

        }
        return new Tuple<long, T>(maxValue, itemWithMaxValue!);
    }
}
