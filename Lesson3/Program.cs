string? day = Console.ReadLine();
if (day == "monday")
{
    Console.WriteLine("1");
}
else if (day == "tuesday")
    Console.WriteLine("2");
else if (day == "wednesday")
    Console.WriteLine("3");
else if (day == "thursday")
    Console.WriteLine("4");
else if (day == "friday")
    Console.WriteLine("5");
else if (day == "saturday")
    Console.WriteLine("6");
else if (day == "sunday")
    Console.WriteLine("7");

//exercises-----/-----/-----/
int a = 2;
int b = 6;
int c = 10;
int max;
int min;

//ex21
if (a >= b && a >= c)
    max = a;
else if (b >= c && b >= a)
    max = b;
else max = c;
Console.WriteLine(max);

//ex22
if (a <= b && a <= c)
    min = a;
else if (b <= c && b <= a)
    min = b;
else min = c;
Console.WriteLine(min);

//ex23
if (a == 1 || b == 1 || c == 1)
    Console.WriteLine("true");
else Console.WriteLine("false");

//ex24
if (a == 2 && b == 2)
    Console.WriteLine("true");
else if (a == 2 && c == 2)
    Console.WriteLine("true");
else if (b == 2 && c == 2)
    Console.WriteLine("true");
else Console.WriteLine("false");

//ex25
if ((a + b) < c || (a + c) < b || (b + c) < a)
    Console.WriteLine("y=1");
else Console.WriteLine("y=2");

//ex26
if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
    Console.WriteLine(1);
else Console.WriteLine(2);

//ex27
if ((a + c) / 2 == b)
    Console.WriteLine(true);
else
    Console.WriteLine(false);

//ex28
if (c / b == b / a)
    Console.WriteLine(true);
else
    Console.WriteLine(false);

//ex29,ex30
if (max == a)
{
    if (min == b)
    {
        Console.WriteLine($"{a} {c} {b}");
        Console.WriteLine($"{b} {c} {a}");
    }
    else
    {
        Console.WriteLine($"{a} {b} {c}");
        Console.WriteLine($"{c} {b} {a}");
    }
}
if (max == b)
{
    if (min != a)
    {
        Console.WriteLine($"{b} {a} {c}");
        Console.WriteLine($"{c} {a} {b}");
    }
    else
    {
        Console.WriteLine($"{b} {c} {a}");
        Console.WriteLine($"{a} {c} {b}");
    }
}
if (max == c)
{
    if (min == b)
    {
        Console.WriteLine($"{c} {a} {b}");
        Console.WriteLine($"{b} {a} {c}");
    }
    else
    {
        Console.WriteLine($"{c} {b} {a}");
        Console.WriteLine($"{a} {b} {c}");
    }
}
//ex calculator-----/

double firstValue, secondValue;
string action;

Console.WriteLine("type first number");
firstValue = double.Parse(Console.ReadLine());

Console.WriteLine("type second number");
secondValue = double.Parse(Console.ReadLine());

Console.WriteLine("choose operation: '+' '-' '*' '/'");
action = Console.ReadLine();

switch (action)
{
    case "+":
        Console.WriteLine(firstValue + secondValue);
        break;
    case "-":
        Console.WriteLine(firstValue - secondValue);
        break;
    case "*":
        Console.WriteLine(firstValue * secondValue);
        break;
    case "/":
        if (secondValue == 0)
            Console.WriteLine(0);
        else
            Console.WriteLine(firstValue / secondValue);
        break;
    default:
        Console.WriteLine("Error");
        break;
}
