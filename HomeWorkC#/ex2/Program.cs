/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
while (true)
{
Console.Clear();
Console.WriteLine("Введите 2 числа для сравнения");
Console.WriteLine("Введите 1-е число для сравнения");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-е число для сравнения");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Начинаю сравнение .....");
if (a>b)
    {
    Console.WriteLine($"Max = {a}");
    }
else
    {
    Console.WriteLine($"Max = {b}");
    }
Console.WriteLine("Если хотите повторить нажмите Enter");
Console.WriteLine("если нет просто введите любой символ");
string answ = Console.ReadLine();
if (!String.IsNullOrEmpty(answ))
    break;
        }