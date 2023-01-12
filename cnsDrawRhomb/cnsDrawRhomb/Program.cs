//ДЗ: нарисовать ромб, с параметрами как у прямоугольника
using System;

bool isContinue = true;
bool isFill = true;
do
{
    
    Console.WriteLine("Введите высоту (нечётное значение):");
    int y = Convert.ToInt32(Console.ReadLine());

    

    int y_cent = y / 2;

    Console.WriteLine("Требуется заливка? [Y/N] ");
    isFill = (Console.ReadLine().ToUpper() == "Y");

    int x = y - 2;
    int x_cent = x / 2;
    int j;

    for (int i = 0; i < y_cent + 1; i++)
    {
        if (isFill == true) 
            Console.WriteLine(new String(' ', x_cent - i + 1) + new String('*', i + 1) + new String('*', i));
        else 
        {
            if (i == 0) Console.WriteLine(new String(' ', x_cent - i + 1) + "*");
            else Console.WriteLine(new String(' ', x_cent - i + 1) + "*" + new String(' ', 2 * i - 1) + "*");
        } 
            
    }

    for (int i = y_cent + 1; i < y; i++)
    {
        if (isFill == true) Console.WriteLine(new String(' ', y_cent - x + i - 1) + new String('*', y - i - 1) + new String('*', y - i));
        else
        {
            if (i != y - 1) Console.WriteLine(new String(' ', y_cent - x + i - 1) + "*" + new String(' ', y * 2 - i * 2 - 3) + "*");
            else Console.WriteLine(new String(' ', y_cent - x + i - 1) + "*");
        }
    }

    Console.Write("Повторить? [Y/N] ->");
    isContinue = (Console.ReadLine().ToUpper() == "Y");
    Console.WriteLine();
} while (isContinue);
