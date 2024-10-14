namespace Udemi_StarWarsPlanetStats.JustInCaseDB
{
    public class JustInCaseResident
    {
        private string[] _data =
        {
            "{\"name\": \"Resident N 123\",\"height\": \"100\",\"birth_year\": \"1111\",\"gender\": \"male\"}",
            "{\"name\": \"Resident N abc\",\"height\": \"200\",\"birth_year\": \"1222\",\"gender\": \"female\"}",
            "{\"name\": \"Resident N xyz\",\"height\": \"300\",\"birth_year\": \"1333\",\"gender\": \"unknown\"}"
        };

        private Random _rnd = new Random();

        public string GetData ()
        {
            int r = _rnd.Next(1, 4);
            return _data[r-1];
        }
            
    }
}
