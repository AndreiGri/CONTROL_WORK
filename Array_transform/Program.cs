using System;
using static System.Console;

Clear();

string text1 = "Введите строку из четырёх или более слов: ";
string text2 ="Вы ввели менее четырёх слов." +
              "\n" +
              "Попробуйте ещё ввести строку из четырёх или более слов: ";
string[] a = CreatedArray();
ShowArrays(a, NewArr(a));


string[] CreatedArray()
{
    string[] array = WriteAndRead(text1);
    while (array.Length < 4)
    {
        array = WriteAndRead(text2);
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

string[] NewArr(string[] arr)
{
    int n = new Random().Next(4);
    string[] newArray = new string[n];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = arr[new Random().Next(0, arr.Length)];
    }
    return newArray;
}

void ShowArrays(string[] arr1, string[] arr2)
{
    Write("[" + string.Join(", ", arr1) + "] -> [" + string.Join(", ", arr2) + "]");
}