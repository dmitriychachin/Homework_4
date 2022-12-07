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

int num = GetNumber("Введите число");
int num1 = num;
int num2 = num;
int sum = 0;
int Length = 0;
int a = 0;

while (num1 != 0)
{
    num1 = num1 / 10;
    Length = Length +1;
}

for (int i = 1; i <= Length; i++)
{
    a = num2 % 10;
    num2 = num2 / 10;
    sum = sum + a;
}

Console.WriteLine($"Сумма цифр числа {num} равна {sum}");
