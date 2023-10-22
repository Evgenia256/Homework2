Console.WriteLine("Enter number 1:");
var firstNumber =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2:");
var secondNumber =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter operation (* or ^ or % or + or -):");
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
    : $"Number 1 ({firstNumber}) {operationCharacter} Number 2 ({secondNumber}) = {result}";

Console.WriteLine(resultMessage);
