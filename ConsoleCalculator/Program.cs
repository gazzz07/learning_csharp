int calcAnswer;
int firstNumber;
int secondNumber;
char operatorSign;

UserInput();
OperatorLogic();
Answered();


void OperatorLogic()
{
    if (operatorSign == '+')
    {
        calcAnswer = firstNumber + secondNumber;
    }
    else if (operatorSign == '-')
    {
        calcAnswer = firstNumber - secondNumber;
    }
    else if (operatorSign == '/')
    {
        calcAnswer = firstNumber / secondNumber;
    }
    else if (operatorSign == '*')
    {
        calcAnswer = firstNumber * secondNumber;
    }
    else
    {
        Console.WriteLine("error");
    }
}

void UserInput()
{
    Console.WriteLine("Enter your first number:");
    firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Operation:");
    operatorSign = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Enter your second number:");
    secondNumber = Convert.ToInt32(Console.ReadLine());
}

void Answered()
{
    Console.WriteLine($"{firstNumber} {operatorSign} {secondNumber} = {calcAnswer}");
}