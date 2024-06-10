namespace Udemi_VideoGames_Exceptions.UserInterface
{
    public class UserOutput
    {

        public static void PrintInRed(string text)
        {
            var originalColour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = originalColour;
        }

    }
}
