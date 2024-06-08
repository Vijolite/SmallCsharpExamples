using Udemi_VideoGames_Exceptions.Model;

namespace Udemi_VideoGames_Exceptions.UserInterface
{
    public class UserInput
    {
        public static string Input()
        {
            string x = Console.ReadLine();
            return x;
        }

        public static JsonFile TryGetFileFormUser()
        {
            bool correctInput = false;
            JsonFile file = new JsonFile(String.Empty);
            do
            {
                Console.WriteLine("Enter the name of the file you want to read");
                var fileName = Input();
                switch (fileName) 
                {
                    case null: 
                        Console.WriteLine("File name cannot be null"); //Ctrl + Z
                        break;
                    case "":
                        Console.WriteLine("File name cannot be empty");
                        break;
                    default:
                        file = new JsonFile(fileName);
                        if (file.Exist()) correctInput = true;
                        else Console.WriteLine("File not found");
                        break;
                }
            } while (!correctInput);

            return file;
        }
    }
}
