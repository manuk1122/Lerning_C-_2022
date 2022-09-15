Console.WriteLine ("Введите день недели");
int week = int.Parse(Console.ReadLine());
switch (week)
{
    case 1:
        Console.WriteLine ("Понедельник");
        break;
    case 2:
       Console.WriteLine ("Вторник");
        break;
    case 3:
        Console.WriteLine ("Среда");
        break;
    case 4:
       Console.WriteLine ("Четверг");
       break;
    case 5:
        Console.WriteLine ("Пятница");
        break;
    case 6:
        Console.WriteLine ("Суббота");
        break;
    case 7:
        Console.WriteLine ("Воскресенье");
        break;
    default:
        Console.WriteLine ("Вы ввели число не соответсвтующее дню неделт");
        break;
}