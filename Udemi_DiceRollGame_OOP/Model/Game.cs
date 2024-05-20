using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemi_DiceRollGame_OOP.Model
{
    public class Game
    {
        public static int NumberOfAttempts = 0;
        public static bool ValueIsGuessed = false;
        public Dice Dice = new Dice();

        public Game()
        {
            Dice.Roll();
        }

        public int TryGetNumberFormUser()
        {
            UserOutput.Output("Enter your guess");
            int guessInt = UserInput.TryGetNumberFormUser();
            return guessInt;
        }

        public void WinOrLose()
        {
            while (!ValueIsGuessed && NumberOfAttempts<3)
            {
                int guess = TryGetNumberFormUser();
                if (guess == Dice.Value)
                {
                    ValueIsGuessed = true;
                }
                else
                {
                    UserOutput.Output("Wrong number!");
                    NumberOfAttempts++;
                }
            }
            if (ValueIsGuessed)
            {
                UserOutput.Output("You won!");
            }
            else
            {
                UserOutput.Output("You lost!");
            }
        }
    }
}
