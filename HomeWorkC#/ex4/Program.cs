/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
while (true) 
{
    Console.Clear();
    Console.WriteLine("Введите 3 числа и программа выведет вам наибольшее из них");
    Console.WriteLine("Введите 1-е число");
    long a = long.Parse(Console.ReadLine());
    Console.WriteLine("Введите 2-е число");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите 3-е число");
    int c = int.Parse(Console.ReadLine());
    Console.WriteLine("Начинаю сравнение....");
    if (a>b && a>c )
        {    
        Console.WriteLine($"{a}, {b}, {c}, -> {a}");
        }
    else if (c>b && c>a )
        {
            Console.WriteLine($"{a}, {b}, {c}, -> {c}");
        }
    else 
        {
            Console.WriteLine($"{a}, {b}, {c}, -> {b}");
        }
    Console.WriteLine("Если хотите повторить нажмите Enter");
    Console.WriteLine("если нет просто введите любой символ");
    string answ = Console.ReadLine();
    if (String.IsNullOrEmpty(answ))
        {}
    else 
        {
            break;
        }
}
