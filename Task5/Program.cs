/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
 
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()); 
string str = number.ToString();  
int[] num = new int[str.Length];

Console.Write(str.Length);
Console.WriteLine();

//string str = new int[str.Length];           //Объвление нового int-массива "num"
bool result = false;
//Console.WriteLine(stnum.Length);
for(int i=0; i < str.Length; i++)         //Заполнение массива "doublA" из строчного массива "PointA"
    {
        num[i] = int.Parse(str[i].ToString());
        //Console.Write(num[i]);
        //Console.WriteLine(num[2]);
    }
//Console.Write(num[4]);

for (int i = 0; i < str.Length/2; i++)
    
    if(num[i] == num[str.Length - 1 - i]) result = true;
    
    else
    {
       Console.WriteLine("Число НЕ является палиндромом");
       result = false;
       break;
        //result = false;
       // Console.WriteLine(result);
       // Console.WriteLine(str.Length);
    }    
 


//Console.WriteLine(num[0]);
if(result == true) Console.WriteLine("Число является палиндромом");


