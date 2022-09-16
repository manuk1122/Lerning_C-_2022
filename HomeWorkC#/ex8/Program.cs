/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */
while (true)
{
    Console.Clear();
    Console.WriteLine("Введите целое число и программа выведет все четные числа от 1 до N");
    int a = int.Parse(Console.ReadLine());
    Console.Write($"{a} -> ");
    for (int i = 1; i<=a; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($" {i} ");
        }
        else
        {}
    }
Console.WriteLine();
Console.WriteLine("Если хотите повторить нажмите Enter");
Console.WriteLine("если нет просто введите любой символ");
string answ = Console.ReadLine();
if (String.IsNullOrEmpty(answ))
    {

    }
else 
    {
        break;
    }
}