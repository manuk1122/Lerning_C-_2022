/* # Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача 2 (задача со звёздочкой): Вывести первые n строк треугольника Паскаля. 
Реализовать вывод в виде равнобедренного треугольника.

`N = 7 -> https://ibb.co/yWPZbG7` */

int fact(int number)
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
        fact *= i;
    }
    return fact;
}
//Console.WriteLine(fact(5));

string binomMAss(int n)
{
    string c ="";
    for (int i = 0; i <= n; i++)
    {
         c += (fact(n) / (fact(i) * fact(n - i))).ToString();
         c+=' ';
    }
    Console.WriteLine();
    return c;
}

static string Tabs(int n)
{
    return new string(' ', n);
}

int numberOfRows = 0;

while (true)
{

    Console.Clear();
    try
    {
        Console.WriteLine("Введите число строк для печати треугольника Паскаля");
        numberOfRows = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfRows; i++)
           { Console.Write(Tabs(numberOfRows-i-1)+binomMAss(i));
           }
           Console.WriteLine();
    }
    
    catch { }
    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
}