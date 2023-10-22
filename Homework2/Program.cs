Console.WriteLine("Напишите число №1:");
var firstNumber =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число №2:");
var secondNumber =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите знак операции * или ^ или % или + или - :");
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
    ? $"Извините, операция {operationCharacter} не поддерживается"
    : $"Число 1 ({firstNumber}) {operationCharacter} Число 2 ({secondNumber}) = {result}";

Console.WriteLine(resultMessage);
