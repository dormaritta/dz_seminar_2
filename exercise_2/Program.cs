﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
string index = Console.ReadLine()!;

if (int.Parse (index) > 99)
{ 
    Console.WriteLine(index [2]); 
}
else
{
    Console.WriteLine("Третьей цифры нет");
}