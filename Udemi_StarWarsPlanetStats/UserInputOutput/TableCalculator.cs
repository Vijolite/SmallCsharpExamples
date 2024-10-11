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
        long maxValue = -1;
        T itemWithMaxValue = default(T);
        foreach (var item in Items)
        {
            var property = item.GetType().GetProperties().Where (x => x.Name.ToLowerInvariant() == columnName).FirstOrDefault();
            var value = property?.GetValue(item);
            if (Int64.TryParse((string?)value, out long numberValue))
            {
                if (numberValue > maxValue)
                {
                    maxValue = numberValue;
                    itemWithMaxValue = item;
                }
            }

        }
        return new Tuple<long, T>(maxValue, itemWithMaxValue!);
    }

    public Tuple<long, T> FinMinInColumn(string columnName)
    {
        var listOfValues = new List<int>();
        long minValue = 100000000000000000;
        T itemWithMinValue = default(T);
        foreach (var item in Items)
        {
            var property = item.GetType().GetProperties().Where(x => x.Name.ToLowerInvariant() == columnName).FirstOrDefault();
            var value = property?.GetValue(item);
            if (Int64.TryParse((string?)value, out long numberValue))
            {
                if (numberValue < minValue)
                {
                    minValue = numberValue;
                    itemWithMinValue = item;
                }
            }

        }
        return new Tuple<long, T>(minValue, itemWithMinValue!);
    }
}
