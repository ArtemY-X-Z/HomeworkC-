Console.WriteLine("ПРИВЕТ");

int programm, numb;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Программа которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа..");
    Console.WriteLine("2. Программа которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет..");
    Console.WriteLine("3. Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.).");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:    // Задача 10: 
            int number = ReadInt("Введите трехзначное число: ");
            int amount = number.ToString().Length;

            if (amount < 3 || amount > 3)
            {
             Console.WriteLine("Вы ввели не трехзначное число");
            }
            else
            {
             Console.WriteLine(InCenter(number));
            }
            int ReadInt(string message)
            {
             Console.Write(message);
             return Convert.ToInt32(Console.ReadLine());
            }
            int InCenter(int a)
            {
             int result = ((a / 10) % 10);
             return result;
            }
            break;

        case 2:    // Задача 13: 
            int Number = ReadInt("Введите число: ");
            int count = Number.ToString().Length;
            Console.Write(MakeArray(Number, count));
            int MakeArray(int a, int b)
            {
                int result = 0;
                    if (b < 3)
                    {
                      Console.Write("Третьей цифры нет, держи: ");
                    }
                    else
                    {
                        int c = 1;
                        for (int i = b; i > 3; i--)
                        {
                         c = c * 10;
                        }

                        result = (a / c) % 10;
                    }
                return result;

            }
            break;


        case 3:    // Задача 15: 
           
            int dayNumber = ReadInt("Введите число от 1 до 7: ");
            Console.WriteLine(WorkHoliday(dayNumber));
            string WorkHoliday(int a)
            {
                 if (a > 0 && a < 8)
                {
                    if (a == 7 || a == 6)
                    {
                    Console.Write("Под цифрой " + a + " - Выходной");
                    }
                    else
                    { 
                    Console.Write("Под цифрой " + a + " - Рабочий");
                    }
                }
                else
                {
                Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
                }
                return " день.";
            }
            break;

    
        default:
            begin = false;
            break;
         
    }
    
}

