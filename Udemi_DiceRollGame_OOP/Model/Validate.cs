using System;

namespace Udemi_DiceRollGame_OOP.Model
{
    public static class Validate
    {
        public static bool ValidateIntNumber(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}
