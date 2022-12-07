//функция получения числа с консоли
int GetNumber(string message)
{
int result = 0;
bool isCorrect = false;


while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result != 0)
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не число или 0. Введите корректное число");
}
}

return result;
}

int num = GetNumber("Введите число, которое надо возвести в степень");
int num1 = GetNumber("Введите степень в которую надо возвести");

double result = Math.Pow(num, num1);

Console.WriteLine($"Число {num} в степени {num1} равно {result}");