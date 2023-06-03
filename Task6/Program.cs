/*На столе лежат n монеток. Некоторые из них лежат вверх решкой,
а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть,
чтобы все монетки были повернуты вверх одной и той же стороной.
1-Решка
0-Орел*/

Console.WriteLine("Введите количество монеток");
int num = int.Parse(Console.ReadLine()); 
int[] coins = new int[num];
int count = 0;


for (int i = 0; i < num; i++)
{
    coins[i] = new Random().Next(1,0);
    if(coins[i] == 0) count = count + 1;

}
Console.WriteLine($"Количество нулей  {count}");
