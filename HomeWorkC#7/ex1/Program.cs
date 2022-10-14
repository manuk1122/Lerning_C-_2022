/* # Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

`m = 3, n = 4.`

`0,5 7 -2 -0,2`

`1 -3,3 8 -9,9`

`8 7,8 -7,1 9`
 */

while(true)
{
Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

double[,] array = FillArray(rowCount, columnCount);
PrintArray(array);
Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
}



double[,] FillArray(int rows, int columns)
{
    Random rand = new Random(DateTime.Now.Millisecond);
    double[,] filledArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] =Math.Round(rand.NextDouble()*(new Random().Next(-10, 10)),2);
        }
    }
    return filledArray;
}

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" [" + inputArray[i, j]+" ]");
        }
        Console.WriteLine();
    }
}