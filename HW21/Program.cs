//Задача 21
/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите через пробел координаты точки А");
string[] PointA = Console.ReadLine().Split(' ');       //Заполнение  строчного массива "PointA"
double[] doublA = new double[PointA.Length];           //Объвление нового double-массива "doublA"
if(doublA.Length != 3) Console.WriteLine("Произошла ошибка при вводе координат"); 

else
{
    for(int i=0; i < PointA.Length; i++)               //Заполнение массива "doublA" из строчного массива "PointA"
    
     doublA[i] = Double.Parse(PointA[i]);
    
}
Console.WriteLine("Введите через пробел координаты точки B");
string[] PointB = Console.ReadLine().Split(' ');        //Заполнение  строчного массива "PointB"
double[] doublB = new double[PointB.Length];            //Объвление нового double-массива "doublB"
if(doublB.Length != 3) Console.WriteLine("Произошла ошибка при вводе координат"); 
else
{
    for(int i=0; i < PointB.Length; i++)                //Заполнение массива "doublB" из строчного массива "PointB"
    
        doublB[i] = Double.Parse(PointB[i]);
        
}
//if(doublA.Length != 3 || doublB.Length != 3) Console.WriteLine("Произошла ошибка при вводе координат"); 


    double sqrAB1 = Math.Pow(doublA[0] - doublB[0], 2);
    double sqrAB2 = Math.Pow((doublA[1] - doublB[1]), 2);
    double sqrAB3 = Math.Pow((doublA[2] - doublB[2]), 2);

    double ABLength = Math.Sqrt(sqrAB1 + sqrAB2 + sqrAB3);

    Console.WriteLine($"Длина отрезка АВ равна {ABLength}"); 
    








