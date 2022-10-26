/* # Задача 68: Задайте значения M и N.
 Напишите программу, которая найдёт 
 наибольший общий делитель (НОД) этих
  чисел с помощью рекурсии.

`M = 28; N = 7 -> 7` */





    int Let_GCD_byRecursion(int n, int m)
{
    int temp = m%n;
    if (temp == 0)
        return n;
return Let_GCD_byRecursion(temp,n);
}
while (true)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Введите число N");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число M");
        int M = int.Parse(Console.ReadLine());
        Console.WriteLine(Let_GCD_byRecursion(N, M)); 
    }
    catch{
Console.WriteLine("Ошибка ввода");}

    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
    }