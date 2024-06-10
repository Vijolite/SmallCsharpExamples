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
            if (Items == null) Console.WriteLine("***** The file is empty *****");
            else if (Items.Count == 0) Console.WriteLine("***** The file does not contain any record *****");
            else
            {
                Console.WriteLine("***** The list of our exciting video games: *****");
                int i = 1;
                foreach (var item in Items)
                {
                    Console.WriteLine($"----- {i} -----");
                    //item.Print();
                    Console.WriteLine(item.ToString());
                    i++;
                }
            };
            Console.WriteLine($"---------------");
        }
    }
}
