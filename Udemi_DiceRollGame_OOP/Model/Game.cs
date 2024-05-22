using Udemi_DiceRollGame_OOP.UserInterface;

namespace Udemi_DiceRollGame_OOP.Model
{
    public class Game
    {
        private const int MaxTriesCount = 3;
        private static int _usedNumberOfAttempts = 0;
        private static bool _valueIsGuessed = false;
        private Dice dice = new Dice();

        public Game()
        {
            dice.Roll();
        }

        public GameResult Play()
        {
            while (!_valueIsGuessed && _usedNumberOfAttempts < MaxTriesCount)
            {
                int guess = UserInput.TryGetNumberFormUser("Enter your guess");
                if (guess == dice.Value)
                {
                    return GameResult.Won;
                }
                else
                {
                    UserOutput.Output("Wrong number!");
                    _usedNumberOfAttempts++;
                }
            }
            return GameResult.Lost;
        }

        public void PrintResult (GameResult result)
        {
            var message = result.Equals(GameResult.Lost) ? "You lost :(" : "You won!";
            UserOutput.Output(message);
        }
    }
}
