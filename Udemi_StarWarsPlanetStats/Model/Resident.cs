namespace Udemi_StarWarsPlanetStats.Model
{
    public class Resident
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string BirthYear { get; set; }
        public string Gender { get; set; }
        public Resident(ResultResident result)
        {
            Name = result.name;
            Height = result.height;
            BirthYear = result.birth_year;
            Gender = result.gender;
        }
    }
}
