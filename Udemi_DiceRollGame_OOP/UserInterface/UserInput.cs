using System;
using Udemi_DiceRollGame_OOP.Model;

namespace Udemi_DiceRollGame_OOP.UserInterface
{
    public static class UserInput
    {
        public static string Input()
        {
            string x = Console.ReadLine();
            return x;
        }

        public static int TryGetNumberFormUser(string text)
        {
            UserOutput.Output(text);
            bool correctInt;
            int inputInt = 0;
            do
            {
                var input = Input();
                correctInt = Validate.ValidateIntNumber(input);

                if (!correctInt)
                {
                    UserOutput.Output("Incorrect Input");
                }
                else
                {
                    inputInt = int.Parse(input);
                }
            } while (!correctInt);
            return inputInt;
        }
    }
}