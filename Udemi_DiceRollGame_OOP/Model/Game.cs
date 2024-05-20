using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void WinOrLose()
        {
            while (!_valueIsGuessed && _usedNumberOfAttempts < MaxTriesCount)
            {
                int guess = UserInput.TryGetNumberFormUser("Enter your guess");
                if (guess == dice.Value)
                {
                    _valueIsGuessed = true;
                }
                else
                {
                    UserOutput.Output("Wrong number!");
                    _usedNumberOfAttempts++;
                }
            }
            if (_valueIsGuessed)
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
