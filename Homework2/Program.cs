Console.Write("Enter number 1: ");
// Console - this a class
// . - this is an operator that allows to access members of a class
// Write - is a method, it is a member of class Console
// () - operator that allows to pass arguments to a method and make
// "Enter number 1" - is a string literal
// ; - is a statement terminator, means end of statement in the C#
// In this line we are calling Write method of Console class and passing a string literal as an argument

var firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
var secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter math operation: ");
var operationCharacter = Convert.ToChar(Console.ReadLine());

int? result = operationCharacter switch
{
    '*' => firstNumber * secondNumber,
    '/' => firstNumber / secondNumber,
    '+' => firstNumber + secondNumber,
    '-' => firstNumber - secondNumber,
    '%' => firstNumber % secondNumber,
    _ => null
};

var resultMessage = result == null
    ? $"Sorry, operation '{operationCharacter}' is not supported"
    : $"{firstNumber} {operationCharacter} {secondNumber} = {result}";

Console.WriteLine(resultMessage);
