using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemi_DiceRollGame_OOP.Model
{
    public static class Validate
    {
        public static bool ValidateDiceNumber(int value)
        {
            return value >= 1 && value <= 6;
        }

        public static bool ValidateIntNumber(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}
