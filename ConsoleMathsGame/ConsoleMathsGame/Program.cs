using System.Diagnostics;
using System.Threading;

Console.WriteLine("Welcome to your maths game! Which game would you like to play?");
Console.WriteLine("+ = Addition\n- = Subtraction\n* = Multiplication\n/ = Division\nV = View Previous Games\nQ = Quit");
char gameChoice = Convert.ToChar(Console.ReadLine().ToLower().Trim());
Console.WriteLine("-----");
int correctAnswer = 0;
int firstNumber = 0;
int secondNumber = 0;
int score = 0;
var games = new List<String>();

GameLogic();
MenuReturn();
void MainProgramRepeat()
{
    MenuLogic();
    GameLogic();
    MenuReturn();
}
void MenuLogic()
{
    score = 0;
    Console.WriteLine("+ = Addition\n- = Subtraction\n* = Multiplication\n/ = Division\nV = View Previous Games\nQ = Quit");
    gameChoice = Convert.ToChar(Console.ReadLine().ToLower().Trim());
    Console.WriteLine("-----");
}
void GameLogic()
{
    if (gameChoice == '+')
    {
        Console.WriteLine("Easy or Hard? (E/H): ");
        char chosenDifficulty = Convert.ToChar(Console.ReadLine().ToLower().Trim());
        if (chosenDifficulty == 'e')
        {
            AdditionGameEasy();
        } else if (chosenDifficulty == 'h')
        {
            AdditionGameHard();
        } else
        {
            Console.WriteLine("Invalid choice");
        }
    }
    else if (gameChoice == '-')
    {
        Console.WriteLine("Easy or Hard? (E/H): ");
        char chosenDifficulty = Convert.ToChar(Console.ReadLine().ToLower().Trim());
        if (chosenDifficulty == 'e')
        {
            SubtractionGameEasy();
        }
        else if (chosenDifficulty == 'h')
        {
            SubtractionGameHard();
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
    else if (gameChoice == '*')
    {
        Console.WriteLine("Easy or Hard? (E/H): ");
        char chosenDifficulty = Convert.ToChar(Console.ReadLine().ToLower().Trim());
        if (chosenDifficulty == 'e')
        {
            MultiplicationGameEasy();
        }
        else if (chosenDifficulty == 'h')
        {
            MultiplicationGameHard();
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
    else if (gameChoice == '/')
    {
        Console.WriteLine("Easy or Hard? (E/H): ");
        char chosenDifficulty = Convert.ToChar(Console.ReadLine().ToLower().Trim());
        if (chosenDifficulty == 'e')
        {
            DivisionGameEasy();
        }
        else if (chosenDifficulty == 'h')
        {
            DivisionGameHard();
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
    else if (gameChoice == 'v')
    {
        ViewPrevGames();
    } 
    else if (gameChoice == 'q')
    {
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Invalid choice");
    }
}
void AdditionGameEasy()
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    for (int i = 0; i < 5; i++)
    {

        Random random = new Random();
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        correctAnswer = firstNumber + secondNumber;

        Console.WriteLine($"{firstNumber} + {secondNumber}");

        int userGuess;
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
        }
    }

    stopwatch.Stop();
    double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

    games.Add($"{DateTime.Now} - Addition Game - Score: {score} - Time: {elapsedSeconds}s");
    Console.WriteLine($"Congratulations, you scored {score} points!");
    Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
}
void SubtractionGameEasy()
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    for (int i = 0; i < 5; i++)
    {

        Random random = new Random();
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        correctAnswer = firstNumber - secondNumber;

        Console.WriteLine($"{firstNumber} - {secondNumber}");

        int userGuess;
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
        }
    }

    stopwatch.Stop();
    double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

    games.Add($"{DateTime.Now} - Addition Game - Score: {score} - Time: {elapsedSeconds}s");
    Console.WriteLine($"Congratulations, you scored {score} points!");
    Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
}
void MultiplicationGameEasy()
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    for (int i = 0; i < 5; i++)
    {

        Random random = new Random();
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        correctAnswer = firstNumber * secondNumber;

        Console.WriteLine($"{firstNumber} * {secondNumber}");

        int userGuess;
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
        }
    }

    stopwatch.Stop();
    double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

    games.Add($"{DateTime.Now} - Addition Game - Score: {score} - Time: {elapsedSeconds}s");
    Console.WriteLine($"Congratulations, you scored {score} points!");
    Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
}
void DivisionGameEasy()
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    for (int i = 0; i < 5; i++)
    {

        DivisionNumbersEasy();

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        correctAnswer = firstNumber / secondNumber;

        int userGuess;
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
        }
    }

    stopwatch.Stop();
    double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

    games.Add($"{DateTime.Now} - Addition Game - Score: {score} - Time: {elapsedSeconds}s");
    Console.WriteLine($"Congratulations, you scored {score} points!");
    Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
}
void AdditionGameHard()
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    for (int i = 0; i < 5; i++)
    {

        Random random = new Random();
        firstNumber = random.Next(10, 99);
        secondNumber = random.Next(10, 99);
        correctAnswer = firstNumber + secondNumber;

        Console.WriteLine($"{firstNumber} + {secondNumber}");

        int userGuess;
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
        }
    }

    stopwatch.Stop();
    double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

    games.Add($"{DateTime.Now} - Addition Game - Score: {score} - Time: {elapsedSeconds}s");
    Console.WriteLine($"Congratulations, you scored {score} points!");
    Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
}
void SubtractionGameHard()
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    for (int i = 0; i < 5; i++)
    {

        Random random = new Random();
        firstNumber = random.Next(10, 99);
        secondNumber = random.Next(10, 99);
        correctAnswer = firstNumber - secondNumber;

        Console.WriteLine($"{firstNumber} - {secondNumber}");

        int userGuess;
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
        }
    }

    stopwatch.Stop();
    double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

    games.Add($"{DateTime.Now} - Addition Game - Score: {score} - Time: {elapsedSeconds}s");
    Console.WriteLine($"Congratulations, you scored {score} points!");
    Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
}
void MultiplicationGameHard()
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    for (int i = 0; i < 5; i++)
    {

        Random random = new Random();
        firstNumber = random.Next(10, 99);
        secondNumber = random.Next(10, 99);
        correctAnswer = firstNumber * secondNumber;

        Console.WriteLine($"{firstNumber} * {secondNumber}");

        int userGuess;
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
        }
    }

    stopwatch.Stop();
    double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

    games.Add($"{DateTime.Now} - Addition Game - Score: {score} - Time: {elapsedSeconds}s");
    Console.WriteLine($"Congratulations, you scored {score} points!");
    Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
}
void DivisionGameHard()
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    for (int i = 0; i < 5; i++)
    {

        DivisionNumbersHard();

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        correctAnswer = firstNumber / secondNumber;

        int userGuess;
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
        }
    }

    stopwatch.Stop();
    double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

    games.Add($"{DateTime.Now} - Addition Game - Score: {score} - Time: {elapsedSeconds}s");
    Console.WriteLine($"Congratulations, you scored {score} points!");
    Console.WriteLine($"Time Elapsed: {elapsedSeconds}s");
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
    char playAgain = Convert.ToChar(Console.ReadLine().ToLower().Trim());
    if (playAgain == 'y')
    {
        Console.WriteLine("---");
        MainProgramRepeat();
    } else
    {
        Console.WriteLine("Goodbye!");
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