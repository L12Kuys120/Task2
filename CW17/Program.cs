﻿// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//  в которой находится эта точка.

System.Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());

switch(num)
{
    case 1: 
    System.Console.WriteLine("Вы можете ввести значения X > 0 и Y > 0");
    break;

    case 2: 
    System.Console.WriteLine("Вы можете ввести значения X < 0 и Y > 0");
    break;

    case 3: 
    System.Console.WriteLine("Вы можете ввести значения X < 0 и Y < 0");
    break;

    case 4: 
    System.Console.WriteLine("Вы можете ввести значения X > 0 и Y < 0");
    break;
    default:
    System.Console.WriteLine("Введена неверная четверть!");
    break;
}

//Альтернативное решение 

Console.Clear();
Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine());

if(X > 0 && Y > 0){
    Console.WriteLine("1");
}else if(X < 0 && Y > 0){
    Console.WriteLine("2");
}else if(X < 0 && Y < 0){
    Console.WriteLine("3");
} else if(X > 0 && Y < 0){
    Console.WriteLine("4");
} else if (X == 0 || Y == 0)
    Console.WriteLine("На оси");

