// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("ПРИВЕТ");

int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Программа которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    Console.WriteLine("2. Программа которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine("3. Программа которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:    // Задача 19: 
            Console.WriteLine("Введите число: ");
            string number = Console.ReadLine();
            int len = number.Length;
            if (len == 5)
            {
              if (number[0] == number[4] && number[1] == number[3])
            {
            Console.WriteLine($"{number} - Палиндром");
            }
             else
            {
             Console.WriteLine($"{number} - НЕ палиндром");
            }
            }
             else
            {
             Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
            }
            break;

        case 2:    // Задача 21: 
            int x1 = ReadInt("Введите координату X первой точки: ");
            int y1 = ReadInt("Введите координату Y первой точки: ");
            int z1 = ReadInt("Введите координату Z первой точки: ");
            int x2 = ReadInt("Введите координату X второй точки: ");
            int y2 = ReadInt("Введите координату Y второй точки: ");
            int z2 = ReadInt("Введите координату Z второй точки: ");

            int A = x2 - x1;
            int B = y2 - y1;
            int C = z1 - z2;

            double length = Math.Sqrt(A * A + B * B + C * C);
            Console.WriteLine($"Длинна отрезка {length}");

            int ReadInt(string message)
            {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
            }
            break;

        case 3:    // Задача 23: 
           int number1 = ReadInt1("Введите число N: ");

           for (int i = 1; i <= number1; i++)
           { 
             Console.Write($"{i*i*i} ");
           }

           int ReadInt1(string message)
           {
             Console.Write(message);
             return Convert.ToInt32(Console.ReadLine());
           }
           break;
            

    
        default:
            begin = false;
            break;
         
    }
    
}


