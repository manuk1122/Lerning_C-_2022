//Ввести число и вывести его положительные и отрицательные числа
Console.Clear();

 Console.Write("Введите число: ");

    int num = int.Parse(Console.ReadLine());
int i = -num;
    while (i <= num)
    {
        Console.Write($" {i} ");
        i+=1;
    }
