/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите элементы массива   "); 
int Elements = int.Parse(Console.ReadLine()); 
int[] numbers = new int[Elements];           //объявляется массив "numbers" с длиной = "Elements"

int length = numbers.Length;
bool result = false;                  
Console.WriteLine(length);

for (int i = 0; i < length/2; i++)
{
    if(numbers[i] == numbers[Elements - i])  result = true;  
    else break;
}

Console.WriteLine(result);
