//ДЗ: Нарисовать прямоугольник с параметрами "Ширина", "Высота", "Заливка(да/нет)",
//"Символ дли рисовки", "Символ для заливки", повтор(как в примере с линией)
using System;

bool isContinue = true;
bool isFill = true;
do
{
    Console.WriteLine("Время создавать прямоугольник");
    Console.WriteLine("Введите длину");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите ширину");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Требуется заливка? [Y/N] ->");
    isFill = (Console.ReadLine().ToUpper() == "Y");

    for (int i = 0; i < y; i++)
    {
        if (isFill == true)
        {
            Console.WriteLine(new String('*', x));
        }
        else
        {
            if (i % (y - 1) == 0)
            {
                Console.WriteLine(new String('*', x));
            }
            else
            {
                Console.WriteLine('*' + new String(' ', x-2) + '*');
            }
        }
    }

    Console.Write("Повторить? [Y/N] ->");
    isContinue = (Console.ReadLine().ToUpper() == "Y");
    Console.WriteLine();
} while (isContinue);
