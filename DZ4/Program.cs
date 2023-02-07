Console.WriteLine("ПРИВЕТ");

int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1.Программа которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
    Console.WriteLine("2.Программа которая принимает на вход число и выдаёт сумму цифр в числе. ");
    Console.WriteLine("3.Программа которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом. ");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:    // Задача 25: 
           Console.WriteLine("введите число A");
           int a = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("введите число B");
           int b = Convert.ToInt32(Console.ReadLine());
           int step = a;

           for (int y = 1; y < b; y++)
           {
             step = step * a;
           }
             Console.WriteLine("A в степени B равно: " + step);
            break;

        case 2:    // Задача 27: 
           Console.WriteLine("введите число");
           int i = Convert.ToInt32(Console.ReadLine());
           int sum = 0;

            while (i > 0)
            {
               int num = i % 10;
               i = i / 10;
               sum = sum + num;
            }
            Console.WriteLine("сумма всех цифр в числе равна: " + sum);

            
            break;


        case 3:    // Задача 29: 
           int lenArray = ReadInt("Введите длинну массива: ");

           int[] randomArray = new int[lenArray];
           for (int o = 0; o < randomArray.Length; o++)
            {
                randomArray[o] = new Random().Next(1,9);
                Console.Write(randomArray[o] + " ");
            }
           int ReadInt(string message)
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

