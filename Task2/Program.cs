// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

Console.WriteLine("Введите значение Х: ");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            int Y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение Х1: ");
            int X1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение Y1: ");
            int Y1 = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Sqrt((X - X1)*(X - X1) + (Y - Y1)*(Y - Y1)));
