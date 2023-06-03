//Задача 23
// Напишите программу, которая принимает на вход число (N) 
//  и выдаёт таблицу кубов чисел от 1 до N.
 
// 3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
 
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int degree = 2;
 
for(int i = 1; i <= num; i++)
{
   if(degree == 2) Console.WriteLine($"Квадрат числа {i} равен {Math.Pow(i, degree)}");  
   else
   if(degree == 3) Console.WriteLine($"Куб числа {i} равен {Math.Pow(i, degree)}");
   else
    Console.WriteLine($"Степень {degree} числа {i} равен {Math.Pow(i, degree)}");
   
}