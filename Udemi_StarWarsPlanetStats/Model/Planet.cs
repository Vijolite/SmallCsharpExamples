namespace Udemi_StarWarsPlanetStats.Model
{
    public class Planet
    {
        public string Name { get; set; }
        public string Diameter { get; set; }
        public string SurfaceWater { get; set; }
        public string Population { get; set; }

        public Planet (Result result)
        {
            Name = result.name;
            Diameter = result.diameter;
            SurfaceWater = result.surface_water;
            Population = result.population;
        }
    }
}
