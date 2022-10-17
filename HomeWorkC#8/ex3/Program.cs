/* # Задача 58: Задайте две матрицы.
 Напишите программу, которая будет находить
  произведение двух матриц.
`Например, даны 2 матрицы:`
`2 4 | 3 4`
`3 2 | 3 3`
`Результирующая матрица будет:`
`18 20`
`15 18` */
int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] MultArray = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                MultArray[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return MultArray;
}









while (true)
{
        Console.ForegroundColor = ConsoleColor.DarkGreen;
   // PrintArray(FillArray(100,100,0,1));
    Console.Clear();
    Console.ResetColor();

    
    try
    {
        Console.WriteLine("Введите количество строк матрицы 1");
        int rowCount1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов матрицы 1");
        int columnCount1 = int.Parse(Console.ReadLine());
        int[,] array1 = FillArray(rowCount1, columnCount1, 1, 10);
        PrintArray(array1);

        Console.WriteLine("Введите количество строк матрицы 2");
        int rowCount2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов матрицы 2");
        int columnCount2 = int.Parse(Console.ReadLine());
        int[,] array2 = FillArray(rowCount2, columnCount2, 1, 10);
        PrintArray(array2);
        if (columnCount1 == rowCount2)
        {

            Console.WriteLine("Перемножаю...");
           PrintArray( Multiplication(array1,array2));


        }
        else Console.WriteLine("Произведение не возможно");

    }

    catch { Console.WriteLine("Ошибка ввода"); }

    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
}