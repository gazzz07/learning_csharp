using System.Diagnostics;
namespace ConsoleMathsGame
{
    internal class GameEngine
    {
        internal static void AdditionGameEasy()
        {
            Console.WriteLine("How many questions?: ");
            string numQuestionsIn = Console.ReadLine();
            int score = 0;

            if (!int.TryParse(numQuestionsIn, out int numQuestionsOut))
            {
                Console.WriteLine("Please enter a number");
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                for (int i = 0; i < numQuestionsOut; i++)
                {

                    Random random = new Random();
                    int firstNumber = random.Next(1, 9);
                    int secondNumber = random.Next(1, 9);
                    int correctAnswer = firstNumber + secondNumber;

                    Console.WriteLine($"{firstNumber} + {secondNumber}");

                    Console.WriteLine("Enter your guess:");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int userGuess))
                    {

                        if (userGuess == correctAnswer)
                        {
                            Console.WriteLine("Correct Answer!\n");
                            score++;
                        }
                        else if (userGuess != correctAnswer)
                        {
                            Console.WriteLine("Incorrect Answer");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }

                stopwatch.Stop();
                double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

                Helpers.games.Add($"{DateTime.Now} - Addition Game (Easy) - Score: {score} - Time: {elapsedSeconds}s");
                Console.WriteLine($"Congratulations, you scored {score} points!");
                Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
            }
        }
        internal static void SubtractionGameEasy()
        {
            Console.WriteLine("How many questions?: ");
            string numQuestionsIn = Console.ReadLine();
            int score = 0;

            if (!int.TryParse(numQuestionsIn, out int numQuestionsOut))
            {
                Console.WriteLine("Please enter a number");
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                for (int i = 0; i < numQuestionsOut; i++)
                {

                    Random random = new Random();
                    int firstNumber = random.Next(1, 9);
                    int secondNumber = random.Next(1, 9);
                    int correctAnswer = firstNumber - secondNumber;

                    Console.WriteLine($"{firstNumber} - {secondNumber}");

                    Console.WriteLine("Enter your guess:");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int userGuess))
                    {

                        if (userGuess == correctAnswer)
                        {
                            Console.WriteLine("Correct Answer!\n");
                            score++;
                        }
                        else if (userGuess != correctAnswer)
                        {
                            Console.WriteLine("Incorrect Answer");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }

                stopwatch.Stop();
                double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

                Helpers.games.Add($"{DateTime.Now} - Subtraction Game (Easy) - Score: {score} - Time: {elapsedSeconds}s");
                Console.WriteLine($"Congratulations, you scored {score} points!");
                Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
            }
        }
        internal static void MultiplicationGameEasy()
        {
            Console.WriteLine("How many questions?: ");
            string numQuestionsIn = Console.ReadLine();
            int score = 0;

            if (!int.TryParse(numQuestionsIn, out int numQuestionsOut))
            {
                Console.WriteLine("Please enter a number");
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                for (int i = 0; i < numQuestionsOut; i++)
                {

                    Random random = new Random();
                    int firstNumber = random.Next(1, 9);
                    int secondNumber = random.Next(1, 9);
                    int correctAnswer = firstNumber * secondNumber;

                    Console.WriteLine($"{firstNumber} * {secondNumber}");

                    Console.WriteLine("Enter your guess:");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int userGuess))
                    {

                        if (userGuess == correctAnswer)
                        {
                            Console.WriteLine("Correct Answer!\n");
                            score++;
                        }
                        else if (userGuess != correctAnswer)
                        {
                            Console.WriteLine("Incorrect Answer");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }

                stopwatch.Stop();
                double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

                Helpers.games.Add($"{DateTime.Now} - Multiplication Game (Easy) - Score: {score} - Time: {elapsedSeconds}s");
                Console.WriteLine($"Congratulations, you scored {score} points!");
                Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
            }
        }
        internal static void DivisionGameEasy()
        {
            Console.WriteLine("How many questions?: ");
            string numQuestionsIn = Console.ReadLine();
            int score = 0;

            if (!int.TryParse(numQuestionsIn, out int numQuestionsOut))
            {
                Console.WriteLine("Please enter a number");
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                for (int i = 0; i < numQuestionsOut; i++)
                {

                    var divisionNumbers = Helpers.DivisionNumbersEasy();
                    int firstNumber = divisionNumbers[0];
                    int secondNumber = divisionNumbers[1];

                    Console.WriteLine($"{firstNumber} / {secondNumber}");
                    int correctAnswer = firstNumber / secondNumber;

                    Console.WriteLine("Enter your guess:");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int userGuess))
                    {

                        if (userGuess == correctAnswer)
                        {
                            Console.WriteLine("Correct Answer!\n");
                            score++;
                        }
                        else if (userGuess != correctAnswer)
                        {
                            Console.WriteLine("Incorrect Answer");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }

                stopwatch.Stop();
                double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

                Helpers.games.Add($"{DateTime.Now} - Division Game (Easy) - Score: {score} - Time: {elapsedSeconds}s");
                Console.WriteLine($"Congratulations, you scored {score} points!");
                Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
            }
        }
        internal static void AdditionGameHard()
        {
            Console.WriteLine("How many questions?: ");
            string numQuestionsIn = Console.ReadLine();
            int score = 0;

            if (!int.TryParse(numQuestionsIn, out int numQuestionsOut))
            {
                Console.WriteLine("Please enter a number");
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                for (int i = 0; i < numQuestionsOut; i++)
                {

                    Random random = new Random();
                    int firstNumber = random.Next(10, 99);
                    int secondNumber = random.Next(10, 99);
                    int correctAnswer = firstNumber + secondNumber;

                    Console.WriteLine($"{firstNumber} + {secondNumber}");

                    Console.WriteLine("Enter your guess:");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int userGuess))
                    {

                        if (userGuess == correctAnswer)
                        {
                            Console.WriteLine("Correct Answer!\n");
                            score++;
                        }
                        else if (userGuess != correctAnswer)
                        {
                            Console.WriteLine("Incorrect Answer");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }

                stopwatch.Stop();
                double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

                Helpers.games.Add($"{DateTime.Now} - Addition Game (Hard) - Score: {score} - Time: {elapsedSeconds}s");
                Console.WriteLine($"Congratulations, you scored {score} points!");
                Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
            }
        }
        internal static void SubtractionGameHard()
        {
            Console.WriteLine("How many questions?: ");
            string numQuestionsIn = Console.ReadLine();
            int score = 0;

            if (!int.TryParse(numQuestionsIn, out int numQuestionsOut))
            {
                Console.WriteLine("Please enter a number");
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                for (int i = 0; i < numQuestionsOut; i++)
                {

                    Random random = new Random();
                    int firstNumber = random.Next(10, 99);
                    int secondNumber = random.Next(10, 99);
                    int correctAnswer = firstNumber - secondNumber;

                    Console.WriteLine($"{firstNumber} - {secondNumber}");

                    Console.WriteLine("Enter your guess:");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int userGuess))
                    {

                        if (userGuess == correctAnswer)
                        {
                            Console.WriteLine("Correct Answer!\n");
                        }
                        else if (userGuess != correctAnswer)
                        {
                            Console.WriteLine("Incorrect Answer");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }

                stopwatch.Stop();
                double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

                Helpers.games.Add($"{DateTime.Now} - Subtraction Game (Hard) - Score: {score} - Time: {elapsedSeconds}s");
                Console.WriteLine($"Congratulations, you scored {score} points!");
                Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
            }
        }
        internal static void MultiplicationGameHard()
        {
            Console.WriteLine("How many questions?: ");
            string numQuestionsIn = Console.ReadLine();
            int score = 0;

            if (!int.TryParse(numQuestionsIn, out int numQuestionsOut))
            {
                Console.WriteLine("Please enter a number");
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                for (int i = 0; i < numQuestionsOut; i++)
                {

                    Random random = new Random();
                    int firstNumber = random.Next(10, 99);
                    int secondNumber = random.Next(10, 99);
                    int correctAnswer = firstNumber * secondNumber;

                    Console.WriteLine($"{firstNumber} * {secondNumber}");

                    Console.WriteLine("Enter your guess:");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int userGuess))
                    {

                        if (userGuess == correctAnswer)
                        {
                            Console.WriteLine("Correct Answer!\n");
                            score++;
                        }
                        else if (userGuess != correctAnswer)
                        {
                            Console.WriteLine("Incorrect Answer");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }

                stopwatch.Stop();
                double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

                Helpers.games.Add($"{DateTime.Now} - Multiplication Game (Hard) - Score: {score} - Time: {elapsedSeconds}s");
                Console.WriteLine($"Congratulations, you scored {score} points!");
                Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
            }
        }
        internal static void DivisionGameHard()
        {
            Console.WriteLine("How many questions?: ");
            string numQuestionsIn = Console.ReadLine();
            int score = 0;

            if (!int.TryParse(numQuestionsIn, out int numQuestionsOut))
            {
                Console.WriteLine("Please enter a number");
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                for (int i = 0; i < numQuestionsOut; i++)
                {

                    var divisionNumbers = Helpers.DivisionNumbersHard();
                    int firstNumber = divisionNumbers[0];
                    int secondNumber = divisionNumbers[1];

                    Console.WriteLine($"{firstNumber} / {secondNumber}");
                    int correctAnswer = firstNumber / secondNumber;

                    Console.WriteLine("Enter your guess:");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int userGuess))
                    {

                        if (userGuess == correctAnswer)
                        {
                            Console.WriteLine("Correct Answer!\n");
                            score++;
                        }
                        else if (userGuess != correctAnswer)
                        {
                            Console.WriteLine("Incorrect Answer");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }

                stopwatch.Stop();
                double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

                Helpers.games.Add($"{DateTime.Now} - Division Game (Hard) - Score: {score} - Time: {elapsedSeconds}s");
                Console.WriteLine($"Congratulations, you scored {score} points!");
                Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
            }
        }
        internal static void EasyRandomGame()
        {
            Random random = new Random();
            int randomEasy = random.Next(0, 3);
            switch (randomEasy)
            {
                case 0:
                    GameEngine.AdditionGameEasy();
                    break;
                case 1:
                    GameEngine.SubtractionGameEasy();
                    break;
                case 2:
                    GameEngine.MultiplicationGameEasy();
                    break;
                case 3:
                    GameEngine.DivisionGameEasy();
                    break;
                default:
                    break;

            }

        }
        internal static void HardRandomGame()
        {
            Random random = new Random();
            int randomHard = random.Next(0, 3);
            switch (randomHard)
            {
                case 0:
                    GameEngine.AdditionGameHard();
                    break;
                case 1:
                    GameEngine.SubtractionGameHard();
                    break;
                case 2:
                    GameEngine.MultiplicationGameHard();
                    break;
                case 3:
                    GameEngine.DivisionGameHard();
                    break;
                default:
                    break;

            }

        }
    }
}
