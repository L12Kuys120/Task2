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