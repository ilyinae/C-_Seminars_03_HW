﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
if (num.Length == 5)
    Console.WriteLine(num[0] == num[4] && num[1] == num[3]);
else    
    Console.WriteLine("Ошибка ввода");