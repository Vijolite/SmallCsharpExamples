using Udemi_StarWarsPlanetStats.Model;

namespace Udemi_StarWarsPlanetStats.UserInputOutput
{
    public static class ResidentsPrinter
    {
        public static void Print (List<PlanetWithResidents> planets)
        {
            foreach (var planet in planets)
            {
                Console.WriteLine(planet.Name.ToUpperInvariant()+":");
                if (planet.Residents.Count() == 0) Console.WriteLine("No registrated residents");
                else Console.WriteLine(String.Join(" * ",planet.Residents.Select(r => r.Name))+"\n");
            }
        }
    }
}
