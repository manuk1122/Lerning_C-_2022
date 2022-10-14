/* //Рекурсия

Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N с помощью рекурсии
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
for(int i = 1 ; i<=N; i++)
Console.Write(""+ i);
*/



int value = int.Parse(Console.ReadLine());

void recursion() {
    if (value > 0) {
        int outp = value;
        value--;
        recursion();
        Console.Write(outp);
    }
    return;
}

    recursion();


   /*  int n = 5;

void Recurs(int n, int i = 10)
{
    if (n < i)
    {
        n++;
        Console.WriteLine(n);
        Recurs(n,i);
    }
    else  return;
}

Recurs(n, 20); */





/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N с помощью рекурсии
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
 */









/*  Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр с помощью рекурсии.
453 -> 12
45 -> 9



int summ = 0;
int pr = 0;
void Recurs(int n)
{
    if (n > 0)
    {
        pr = n % 10;
        summ += pr;
        n = n / 10;
        Recurs(n);
    }

    else 
    Console.WriteLine(summ);
    return;
}

Recurs(12345);


Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
 */

 int summ = 0;
void Recurs(int n)
{
    if (n > 0)
    {
        summ += n % 10;
        Recurs(n / 10);
    }

    else
        Console.WriteLine(summ);
    return;
}

/* Recurs(12345); */

int Recurs2(int n, int b)
{
    if (b == 0)
        return 1;
    return n * Recurs2(n, b - 1);
}

System.Console.WriteLine(Recurs2(3, 2));
*/