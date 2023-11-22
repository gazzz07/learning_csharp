using System.Diagnostics;
using System.Threading.Tasks.Sources;

var games = new List<String>();

MainProgramRepeat();

void MainProgramRepeat()
{
    MenuLogic();
    GameLogic();
    MenuReturn();
}
void MenuLogic()
{
    int score = 0;
    Console.WriteLine("Welcome! Which game would you like to play?");
    Console.WriteLine("+ = Addition\n- = Subtraction\n* = Multiplication\n/ = Division\nR = Random Game\nV = View Previous Games\nQ = Quit");
    Console.WriteLine("-----");
}
void GameLogic()
{
    string chosenDifficulty;
    var gameChoice = Console.ReadLine().ToLower().Trim();

    switch (gameChoice)
    {
        case "+":
            Console.WriteLine("Easy or Hard? (E/H): ");
            chosenDifficulty = Console.ReadLine().ToLower().Trim();
            if (chosenDifficulty == "e")
            {
                Console.Clear();
                AdditionGameEasy();
            }
            else if (chosenDifficulty == "h")
            {
                Console.Clear();
                AdditionGameHard();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid choice");
            }
            break;

        case "-":
            Console.WriteLine("Easy or Hard? (E/H): ");
            chosenDifficulty = Console.ReadLine().ToLower().Trim();
            if (chosenDifficulty == "e")
            {
                Console.Clear();
                SubtractionGameEasy();
            }
            else if (chosenDifficulty == "h")
            {
                Console.Clear();
                SubtractionGameHard();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid choice");
            }
            break;

        case "*":

            Console.WriteLine("Easy or Hard? (E/H): ");
            chosenDifficulty = Console.ReadLine().ToLower().Trim();
            if (chosenDifficulty == "e")
            {
                Console.Clear();
                MultiplicationGameEasy();
            }
            else if (chosenDifficulty == "h")
            {
                Console.Clear();
                MultiplicationGameHard();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid choice");
            }
            break;

        case "/":

            Console.WriteLine("Easy or Hard? (E/H): ");
            chosenDifficulty = Console.ReadLine().ToLower().Trim();
            if (chosenDifficulty == "e")
            {
                Console.Clear();
                DivisionGameEasy();
            }
            else if (chosenDifficulty == "h")
            {
                Console.Clear();
                DivisionGameHard();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid choice");
            }
            break;

        case "r":

            Console.WriteLine("Easy or Hard? (E/H): ");
            chosenDifficulty = Console.ReadLine().ToLower().Trim();
            if (chosenDifficulty == "e")
            {
                Console.Clear();
                EasyRandomGame();
            }
            else if (chosenDifficulty == "h")
            {
                Console.Clear();
                HardRandomGame();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid choice");
            }
            break;

        case "v":

            ViewPrevGames();

            break;

        case "q":

            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
            break;

        default:

            Console.Clear();
            Console.WriteLine("Invalid choice");
            break;
    }
}
void AdditionGameEasy()
{
    Console.WriteLine("How many questions?: ");
    string numQuestionsIn = Console.ReadLine();
    int score = 0;

    if (!int.TryParse(numQuestionsIn, out int numQuestionsOut))
    {
        Console.WriteLine("Please enter a number");
    } else
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

        games.Add($"{DateTime.Now} - Addition Game (Easy) - Score: {score} - Time: {elapsedSeconds}s");
        Console.WriteLine($"Congratulations, you scored {score} points!");
        Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
    }
}

void SubtractionGameEasy()
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

        games.Add($"{DateTime.Now} - Subtraction Game (Easy) - Score: {score} - Time: {elapsedSeconds}s");
        Console.WriteLine($"Congratulations, you scored {score} points!");
        Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
    }
}
void MultiplicationGameEasy()
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

        games.Add($"{DateTime.Now} - Multiplication Game (Easy) - Score: {score} - Time: {elapsedSeconds}s");
        Console.WriteLine($"Congratulations, you scored {score} points!");
        Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
    }
}
void DivisionGameEasy()
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

            var divisionNumbers = DivisionNumbersHard();
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

        games.Add($"{DateTime.Now} - Division Game (Easy) - Score: {score} - Time: {elapsedSeconds}s");
        Console.WriteLine($"Congratulations, you scored {score} points!");
        Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
    }
}
void AdditionGameHard()
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

        games.Add($"{DateTime.Now} - Addition Game (Hard) - Score: {score} - Time: {elapsedSeconds}s");
        Console.WriteLine($"Congratulations, you scored {score} points!");
        Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
    }
}
void SubtractionGameHard()
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

        games.Add($"{DateTime.Now} - Subtraction Game (Hard) - Score: {score} - Time: {elapsedSeconds}s");
        Console.WriteLine($"Congratulations, you scored {score} points!");
        Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
    }
}
void MultiplicationGameHard()
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

        games.Add($"{DateTime.Now} - Multiplication Game (Hard) - Score: {score} - Time: {elapsedSeconds}s");
        Console.WriteLine($"Congratulations, you scored {score} points!");
        Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
    }
}
void DivisionGameHard()
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

            var divisionNumbers = DivisionNumbersHard();
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

        games.Add($"{DateTime.Now} - Division Game (Hard) - Score: {score} - Time: {elapsedSeconds}s");
        Console.WriteLine($"Congratulations, you scored {score} points!");
        Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
    }
}
int[] DivisionNumbersEasy()
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
int[] DivisionNumbersHard()
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
void MenuReturn()
    {
        Console.WriteLine("Would you like to return to the menu? Y/N : ");
        var playAgain = Console.ReadLine().ToLower().Trim();
        switch (playAgain)
        {
            case "y":

                Console.WriteLine("---");
                MainProgramRepeat();
                break;

            case "n":

                Console.WriteLine("Goodbye!");
                Console.WriteLine("Press any key");
                Console.ReadKey();
                break;
            default:
            Console.Clear();
            Console.WriteLine("Invalid");
            MenuReturn();
            break;

        }
    }
void ViewPrevGames()
        {
            Console.WriteLine("Previous Games: ");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
        }
void EasyRandomGame()
{
    Random random = new Random();
    int randomEasy = random.Next(0,3);
    switch (randomEasy)
    {
        case 0:
            AdditionGameEasy();
            break;
        case 1:
            SubtractionGameEasy();
            break;
        case 2:
            MultiplicationGameEasy();
            break;
        case 3:
            DivisionGameEasy();
            break;
        default:
            break;

    }

}
void HardRandomGame()
{
    Random random = new Random();
    int randomHard = random.Next(0, 3);
    switch (randomHard)
    {
        case 0:
            AdditionGameHard();
            break;
        case 1:
            SubtractionGameHard();
            break;
        case 2:
            MultiplicationGameHard();
            break;
        case 3:
            DivisionGameHard();
            break;
        default:
            break;

    }

}