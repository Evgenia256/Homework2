Console.WriteLine("Напишите число №1:");
var firstNumber =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число №2:");
var secondNumber =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите знак операции * или ^ или % или + или - :");
var operationCharacter = Convert.ToChar(Console.ReadLine());
if (operationCharacter == '+')
{
    var sum = firstNumber + secondNumber;
    Console.WriteLine("число №1 + число №2 ="+" "+sum ); 
}
else
{
    Console.WriteLine();
}
if(operationCharacter=='*')
{
    var Mult = firstNumber * secondNumber;
    Console.WriteLine("число №1 * число №2 ="+" "+Mult);
}
else
{
    Console.WriteLine(); 
}
if (operationCharacter == '-')
{
    var Minus = firstNumber - secondNumber;
    Console.WriteLine("число №1 - число №2 ="+" "+Minus); 
}
else
{
    Console.WriteLine();
}
if (operationCharacter == '%')
{
    var RemainderDivision = firstNumber % secondNumber;
    Console.WriteLine("число №1 % число №2 ="+" "+RemainderDivision);
}
else
{
    Console.WriteLine();
}
