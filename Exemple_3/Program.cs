
int []array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,1000000);
    Console.Write($"{array[i]} ");
}


/* OR

//функция получения числа с консоли
int GetNumber(string message)
{
int result = 0;
bool isCorrect = false;


while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result))
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не число. Введите корректное число");
}
}

return result;
}



int []array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = GetNumber("Введите число:");
}

Console.WriteLine("В массиве числа:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
*/