/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */
while (true)
{
    Console.Clear();
Console.WriteLine("Введите число для проверки на четность");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0 )
    {
        Console.WriteLine($"{a} -> Да");
    }
else
    {
        Console.WriteLine($"{a} - > нет ");
    }
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