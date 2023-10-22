// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите число №1:");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число №2:");
int b =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите знак операции * или ^ или % или + или - :");
char c = Convert.ToChar(Console.ReadLine());
if (c == '+')
{
    var sum = a + b;
    Console.WriteLine("число №1 + число №2 ="+" "+sum ); 
}
else
{
    Console.WriteLine();
}
if(c=='*')
{
    var Mult = a * b;
    Console.WriteLine("число №1 * число №2 ="+" "+Mult);
}
else
{
    Console.WriteLine(); 
}
if (c == '-')
{
    var Minus = a - b;
    Console.WriteLine("число №1 - число №2 ="+" "+Minus); 
}
else
{
    Console.WriteLine();
}
if (c == '%')
{
    var RemainderDivision = a % b;
    Console.WriteLine("число №1 % число №2 ="+" "+RemainderDivision);
}
else
{
    Console.WriteLine();
}
