/*
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("Красный текст на белом фоне");
Console.ResetColor();
Console.WriteLine("Обычный текст");

foreach (var color in Enum.GetValues<ConsoleColor>())
{
    Console.WriteLine(color);
}
*/
using System.Drawing;

for (int colorId = 0; colorId < 16; colorId++)
{
    if (colorId == 0)
    {
        Console.BackgroundColor = ConsoleColor.White;
    }
    Console.ForegroundColor = (ConsoleColor)colorId;
    Console.WriteLine("Текст");
    Console.ResetColor();
}

for (int colorId = 0; colorId < 16; colorId++)
{
    for (int backgroundColorId = 0; backgroundColorId < 16; backgroundColorId++)
    {
        Console.BackgroundColor = (ConsoleColor)backgroundColorId;
        Console.ForegroundColor = (ConsoleColor)colorId;
        Console.Write("Hello World");
        Console.ResetColor();
    }
    Console.Write(' ');
    Console.WriteLine();

    Console.ResetColor();
}
