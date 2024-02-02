Console.WriteLine("enter the operation (+, -, *, /)");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("enter a:");
int firstNum = Int32.Parse(Console.ReadLine()); //argument
Console.WriteLine("enter b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Subtraction(firstNum, secondNum);
        break;
    case '*':
        Multiplication(firstNum, secondNum);
        break;
    case '/':
        Division(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}

static void Addition(int a, int b) //parameter
{
    Console.WriteLine($"{a}+{b}={a + b}");
}
static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a}-{b}={a - b}");
}
static void Multiplication(int a, int b)
{
    Console.WriteLine($"{a}*{b}={a * b}");
}
static void Division(int a, int b)
{
    Console.WriteLine($"{a}/{b}={a / b}");
}