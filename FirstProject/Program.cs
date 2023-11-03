Console.WriteLine("What's your name?: ");
string playerName = Console.ReadLine();
Console.WriteLine($"Hello {playerName}, let's play a maths game!\nWould you like to play an Addition, Subtraction, Division or Multiplication game?: ");
string chosenGame = Console.ReadLine();

if (chosenGame == "Addition") {
    Console.WriteLine("You chose Addition, let's begin!");
    additionGame();
} else if (chosenGame == "Subtraction") {
    Console.WriteLine("You chose Subtraction, let's begin!");
    subtractionGame();
} else if (chosenGame == "Division") {
    Console.WriteLine("You chose Division, let's begin!");
    divisionGame();
} else if (chosenGame == "Multiplication") {
    Console.WriteLine("You chose Multiplication, let's begin!");
    multiplicationGame();
} else {
    Console.WriteLine("Invalid answer!");
}

Console.WriteLine($"Would you like to play again, {playerName}? (Y/N)");
char playAgain = Convert.ToChar(Console.ReadLine());

if (playAgain == Y) {

} else {
    Console.WriteLine("Goodbye!");
}


void additionGame() {
    Random randomNumber = new Random();
    int firstNumber = randomNumber.Next(1,10);
    int secondNumber = randomNumber.Next(1,10);
    
    Console.WriteLine($"What is {firstNumber} + {secondNumber}?:");
    int answer = Convert.ToInt32(Console.ReadLine());

    if (answer == firstNumber + secondNumber) {
        Console.WriteLine("That's correct!");
    } else {
        Console.WriteLine("That's incorrect!");
    }

}

void subtractionGame() {
    Random randomNumber = new Random();
    int firstNumber = randomNumber.Next(1,10);
    int secondNumber = randomNumber.Next(1,10);
    
    Console.WriteLine($"What is {firstNumber} - {secondNumber}?:");
    int answer = Convert.ToInt32(Console.ReadLine());

    if (answer == firstNumber - secondNumber) {
        Console.WriteLine("That's correct!");
    } else {
        Console.WriteLine("That's incorrect!");
    }
}

void divisionGame() {
    Random random = new Random();
    int[] numerators = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
    int[] denominators = {1, 2, 5, 10};
    int firstNumber = numerators[random.Next(numerators.Length)];
    int secondNumber = denominators[random.Next(denominators.Length)];

    Console.WriteLine($"What is {firstNumber} / {secondNumber}");
    int answer = Convert.ToInt32(Console.ReadLine());

    if (answer == firstNumber / secondNumber) {
        Console.WriteLine("That's correct!");
    } else {
        Console.WriteLine("That's incorrect!");
    }

}

void multiplicationGame() {
    Random randomNumber = new Random();
    int firstNumber = randomNumber.Next(1,10);
    int secondNumber = randomNumber.Next(1,10);
    
    Console.WriteLine($"What is {firstNumber} x {secondNumber}?:");
    int additionAnswer = Convert.ToInt32(Console.ReadLine());

    if (additionAnswer == firstNumber * secondNumber) {
        Console.WriteLine("That's correct!");
    } else {
        Console.WriteLine("That's incorrect!");
    }
}