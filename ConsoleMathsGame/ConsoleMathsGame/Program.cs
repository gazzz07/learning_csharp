using System.Diagnostics;

int correctAnswer;
int firstNumber;
int secondNumber;
int score;
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
    score = 0;
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
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
            correctAnswer = firstNumber + secondNumber;

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
            /*int userGuess;
            bool validInput;

            do
            {
                Console.WriteLine("Enter your guess:");
                string input = Console.ReadLine();
                validInput = int.TryParse(input, out userGuess);

                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

            } while (!validInput);

            if (userGuess == correctAnswer)
            {
                Console.WriteLine("Correct Answer!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!\n");
            }*/
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
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
            correctAnswer = firstNumber - secondNumber;

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
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
            correctAnswer = firstNumber * secondNumber;

            Console.WriteLine($"{firstNumber} * {secondNumber}");

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

            DivisionNumbersEasy();

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            correctAnswer = firstNumber / secondNumber;

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
            firstNumber = random.Next(10, 99);
            secondNumber = random.Next(10, 99);
            correctAnswer = firstNumber + secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber}");

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
            firstNumber = random.Next(10, 99);
            secondNumber = random.Next(10, 99);
            correctAnswer = firstNumber - secondNumber;

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
            firstNumber = random.Next(10, 99);
            secondNumber = random.Next(10, 99);
            correctAnswer = firstNumber * secondNumber;

            Console.WriteLine($"{firstNumber} * {secondNumber}");

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

            DivisionNumbersHard();

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            correctAnswer = firstNumber / secondNumber;

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
void DivisionNumbersEasy()
    {
        Random random = new Random();

        do
        {

            int firstDivNumber = random.Next(1, 99);
            int secondDivNumber = random.Next(1, 99);

            if (firstDivNumber % secondDivNumber == 0 && firstDivNumber != secondDivNumber)
            {
                firstNumber = firstDivNumber;
                secondNumber = secondDivNumber;
                break;
            }
        } while (true);

    }
void DivisionNumbersHard()
    {
        Random random = new Random();

        do
        {

            int firstDivNumber = random.Next(1, 999);
            int secondDivNumber = random.Next(1, 999);

            if (firstDivNumber % secondDivNumber == 0 && firstDivNumber != secondDivNumber)
            {
                firstNumber = firstDivNumber;
                secondNumber = secondDivNumber;
                break;
            }
        } while (true);

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