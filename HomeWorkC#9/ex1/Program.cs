/* # Задача 64: Задайте значения N и M. 
Напишите программу, которая выведет все чётные натуральные
 числа в промежутке от M до N с помощью рекурсии.

`M = 1; N = 5 -> 2, 4`
`M = 4; N = 8 -> 4, 6, 8` */

int LetShowEvenNumberbyRecursion(int n, int m)
{
    if (n % 2 == 0) 
        Console.WriteLine(n);
    if (n > m) 
        return n;
    return (LetShowEvenNumberbyRecursion(n + 1, m));
}
while (true)
{
        Console.Clear();
        Console.WriteLine("Введите число N");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число M");
        int M = int.Parse(Console.ReadLine());
        LetShowEvenNumberbyRecursion(N, M);
    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
}