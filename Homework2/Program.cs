Console.Write("Enter number 1: ");
var firstNumber =Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
var secondNumber =Convert.ToInt32(Console.ReadLine());
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
