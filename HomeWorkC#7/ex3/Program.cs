/* # Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
`1 4 7 2`
`5 9 2 3`
`8 4 2 4`
`Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.` */
while (true)
{
    try
    {
        Console.WriteLine("Введите количество строк двумерного массива");
        int rowCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов двумерного массива");
        int columnCount = int.Parse(Console.ReadLine());

        int[,] array = FillArray(rowCount, columnCount);
        PrintArray(array);
        
        for (int i = 1; i <= columnCount; i++) Console.WriteLine(Math.Round(Middle(array, i, rowCount), 2));
        Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
    }
    catch
    {
        Console.WriteLine("Ошибка ввода");
    }

}


int[,] FillArray(int rows, int columns)
{
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = (new Random().Next(0, 11));
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j]);
        }
        Console.WriteLine();
    }
}

double Middle(int[,] TempArray, int column, int rows)
{
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += TempArray[i, column - 1];
    }
    return sum / TempArray.GetLength(0);
}
