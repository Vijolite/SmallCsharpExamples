using Udemi_DiceRollGame_OOP.Model;

namespace Udemi_DiceRollGame_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var game = new Game();
            game.WinOrLose();
            Console.ReadLine();
        }
    }
}

