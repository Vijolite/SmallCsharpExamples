namespace Udemi_VideoGames_Exceptions.Model
{
    public class VideoGameStorage
    {
        public List<VideoGame> Items { get; set; } = new List<VideoGame>();

        public VideoGameStorage(List<VideoGame> items)
        {
            Items = items;
        }

        public void Print()
        {
            if (Items.Count > 0)
            {
                Console.WriteLine("***** The list of our exciting video games: *****");
                int i = 1;
                foreach (var item in Items)
                {
                    Console.WriteLine($"----- {i} -----");
                    item.Print();
                    i++;
                }
            }
            Console.WriteLine($"---------------");
        }
    }
}
