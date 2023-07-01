using System;
using static System.Console;

Clear();

string[] CreatedArray()
{
    Write("Введите строку из четырёх или более слов: ");
    string words = ReadLine()!;
    string[] array = words.Split(' ');
    while (array.Length < 4)
    {
        Write("Вы ввели менее четырёх слов.\nПопробуйте ещё ввести строку из четырёх или более слов: ");
        words = ReadLine()!;
        array = words.Split(' ');
    }
    return array;
}


