namespace Udemi_StarWarsPlanetStats.UserInputOutput
{
    public static class UserChoice
    {
        private static readonly string[] _rightChoices = { "population", "diameter", "surface water" };

        private static readonly string _choices = string.Join("\n", _rightChoices.ToList());

        public static string GetChoise()
        {
           
            Console.WriteLine(@"The statistics of which property would you like to see?" +"\n" + _choices);
            bool isRightChoice = false;
            var userInput = "";
            while (! isRightChoice)
            {
                userInput = Console.ReadLine();
                if (_rightChoices.Contains(userInput))
                    isRightChoice = true;
            }
            return userInput!;
        }
    }
}
