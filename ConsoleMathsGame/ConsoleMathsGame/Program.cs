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
        AdditionGame();
    }
    else if (gameChoice == '-')
    {
        SubtractionGame();
    }
    else if (gameChoice == '*')
    {
        MultiplicationGame();
    }
    else if (gameChoice == '/')
    {
        DivisionGame();
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
void AdditionGame()
{
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
    games.Add($"{DateTime.Now} - Addition Game - Score: {score}");
    Console.WriteLine($"Congratulations, you scored {score} points!");
}
void SubtractionGame()
{
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
    games.Add($"{DateTime.Now} - Subtraction Game - Score: {score}");
    Console.WriteLine($"Congratulations, you scored {score} points!");
}
void MultiplicationGame()
{
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
    games.Add($"{DateTime.Now} - Multiplication Game - Score: {score}");
    Console.WriteLine($"Congratulations, you scored {score} points!");
}
void DivisionGame()
{
    for (int i = 0; i < 5; i++)
    {

        DivisionNumbers();

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
    games.Add($"{DateTime.Now} - Division Game - Score: {score}");
    Console.WriteLine($"Congratulations, you scored {score} points!");
}
void DivisionNumbers()
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