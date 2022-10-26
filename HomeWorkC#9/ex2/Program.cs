/* # Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов в промежутке 
 от M до N с помощью рекурсии.
`M = 1; N = 15 -> 120`
`M = 4; N = 8 -> 30` */
int LetShowsumbyRecursion(int n, int m, int sum)
{
    sum+=n;
    if (n == m) return sum;
    return (LetShowsumbyRecursion(n + 1, m, sum));
}
while (true)
{
    try
    {
        Console.Clear();
        int summ = 0;
        Console.WriteLine("Введите число N");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число M");
        int M = int.Parse(Console.ReadLine());
        Console.WriteLine (LetShowsumbyRecursion(N, M, summ));
    }
    catch{
Console.WriteLine("Ошибка ввода");}

    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
    }