﻿Console.Clear();
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
if(a > b) Console.WriteLine(a);
else if (a < b) Console.WriteLine(b);
else Console.WriteLine("==");