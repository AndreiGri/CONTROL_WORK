using System;
using static System.Console;

Clear();

string[] CreatedArray()
{
    string[]array=WriteAndRead("Введите строку из четырёх или более слов: ");
    while (array.Length < 4)
    {
        array=WriteAndRead("Вы ввели менее четырёх слов.\nПопробуйте ещё ввести строку из четырёх или более слов: ");
    }
    return array;
}

string[] WriteAndRead(string text)
{
    Write(text);
    string words = ReadLine()!;
    string[] array = words.Split(' ');
    return array;
}
