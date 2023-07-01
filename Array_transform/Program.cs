using System;
using static System.Console;

Clear();

string[] WriteAndRead()
{
    Write("Введите строку из четырёх или более слов: ");
    string words = ReadLine()!;
    string[] array = words.Split(' ');
    while(array.Length < 3)
    {
        Write("Вы ввели менее четырёх слов.");
        WriteAndRead();
    }
    return array;
}



