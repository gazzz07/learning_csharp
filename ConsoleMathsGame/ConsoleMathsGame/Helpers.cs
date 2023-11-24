namespace ConsoleMathsGame
{
    internal class Helpers
    {
        internal static List<string> games = new List<String>();
        internal static int[] DivisionNumbersEasy()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 99);
            int secondNumber = random.Next(1, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;

        }
        internal static int[] DivisionNumbersHard()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 999);
            int secondNumber = random.Next(1, 999);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 999);
                secondNumber = random.Next(1, 999);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
        internal static void ViewPrevGames()
        {
            Console.WriteLine("Previous Games: ");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
        }
    }
}
