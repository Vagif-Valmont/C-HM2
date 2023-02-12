// Семинар 2 (Практическое задание)
//1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool inWork = true;

while (inWork)
{
    Console.Write("Выбери задачу ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch(i)
        {
            case 1: //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            {
                int num = new Random().Next(100, 1000);
                Console.WriteLine(num);
                int a = num / 10 % 10;
                Console.WriteLine(a);        
                break;
            }
			case 2://Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            {
                Console.WriteLine("Введите число");
                int n = int.Parse(Console.ReadLine());
                string s = n.ToString();
                int len = s.Length;
                if (len > 2)
                {
                    Console.WriteLine(s[2]);
                }
                else
                {
                    Console.WriteLine("третьей цифры нет");
                }


                break;
            }
            case 3://Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            {
                string[] days = new String[]{"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
                Console.Write("Ведите день недели: ");
                int day = int.Parse(Console.ReadLine());
                if (day == 6 || day == 7) System.Console.WriteLine(days[day-1] + " - выходной");
                else if (day < 6 && day > 0) System.Console.WriteLine(days[day-1] + " - не выходной");
                else 
                {
                    System.Console.WriteLine("такого дня нет");
                }
                break;
            }
            case -1: inWork = false; break;
        }
    }
}

