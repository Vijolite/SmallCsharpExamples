using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemi_VideoGames_Exceptions.Model
{
    public class VideoGame
    {
        public string Title { get; }
        public int ReleaseYear { get; }
        public decimal Rating { get; }

        public VideoGame (string title, int releaseYear, decimal rating)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Rating = rating;
        }

        public void Print()
        {
             Console.WriteLine($"Game: {Title} Year: {ReleaseYear} Rating: {Rating}");
        }

        public override string ToString()
        {
            return $"Game: {Title} Year: {ReleaseYear} Rating: {Rating}";
        }
    }
}
