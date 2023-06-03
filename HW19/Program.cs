/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
 
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()); 
string str = number.ToString();  
int[] num = new int[str.Length];
 
bool result = false;

for(int i=0; i < str.Length; i++)         //Заполнение массива num 
    
    num[i] = int.Parse(str[i].ToString());
     
for (int i = 0; i < str.Length/2; i++)    //Проверка на палидромность)
    
    if(num[i] == num[str.Length - 1 - i]) result = true;
    
    else
    {
       Console.WriteLine("Число НЕ является палиндромом");
       result = false;
       break;
    }    

if(result == true) Console.WriteLine("Число является палиндромом");