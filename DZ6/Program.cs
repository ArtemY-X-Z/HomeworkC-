// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа:");
string numbers = Console.ReadLine();
// нам нужно перебрать каждый элемент строки, если это не запятая или пробел, кладм его в массив, если запятая или пробле. делаем ++
string[] newNumbers = new string[numbers.Length];
int k = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
    if (numbers[i] == ',')
    {
        k++;
    }
    else
    {
        newNumbers[k] = newNumbers[k] + $"{numbers[i]}";
    }
}
k++;
int[] resultNumbers = new int[k];
PrintArray(resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < k; i++)
{
    if (resultNumbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine("Количество чисел больше 0: " + sum);

void PrintArray(int[] array, string[] string1)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(string1[i]);
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

////////////////////////////////////////////////////////////////////////
// Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double pointX;
double pointY;

Console.Write("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите по очереди b1, k1, b2 и k2 одной строкой через пробел: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int a = arr[1];
int b = arr[3];
int c = arr[0];
int d = arr[2];

if (a == b)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    pointX = (double)(d - c) / (a - b);
    pointY = (double)a * (d - c) / (a - b) + c;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х: {pointX:0.00}");
    Console.WriteLine($"Y: {pointY:0.00}");
}