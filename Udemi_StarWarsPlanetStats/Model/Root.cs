namespace Udemi_StarWarsPlanetStats.Model
{
    public class Root
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Result> results { get; set; }

        public List<Planet> Extract()
        {
            return results.Select(item => new Planet(item)).ToList();
        }
    }
}

