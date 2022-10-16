/* # Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.
`Например, задан массив:
`1 4 7 2`
`5 9 2 3`
`8 4 2 4`
`5 2 6 7`
`Программа считает сумму элементов в каждой 
строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка`
 */

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
// печать цветной строки с наименьшей суммой
void PrintArrayColor(int[,] inputArray, int posofrow)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (i == posofrow)
           { Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" " + inputArray[i, j]);}
            else
            {
                Console.ResetColor();
                Console.Write(" " + inputArray[i, j]);}
            }
        Console.WriteLine();    
        }
        
    }
// нахождение суммы строки массива
int SumOfRow(int[,] array, int rows, int columns)
{
    int sum = 0;
    for (int i = 0; i < columns; i++)
    {
        sum += array[rows, i];
    }
    return sum;
}

while (true)
{
    Console.Clear();
    try
    {
        Console.WriteLine("Введите количество строк двумерного массива");
        int rowCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов двумерного массива");
        int columnCount = int.Parse(Console.ReadLine());



        int[,] array = FillArray(rowCount, columnCount, 1, 10);
        int[] massOfSum = new int[rowCount];
        PrintArray(array);
        for (int i = 0; i < rowCount; i++)
        {
            Console.WriteLine($"{i + 1}-я строка сумма = {SumOfRow(array, i, columnCount)}");
            massOfSum[i] = SumOfRow(array, i, columnCount);
        }
       int maxPos = 0 ;
        int maxEl = massOfSum[0];
        for (int i = 0; i < massOfSum.Length; i++)
        {
            if (maxEl >= massOfSum[i])
            {
                maxEl = massOfSum[i];
                maxPos = i;
            }}
             Console.WriteLine();
             Console.WriteLine($"{maxPos+1}-я строка ");
            
    PrintArrayColor(array,maxPos);
    
    }

catch { Console.WriteLine("Ошибка ввода"); }

    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
}