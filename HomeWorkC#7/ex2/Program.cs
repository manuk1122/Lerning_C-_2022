/* # Задача 50. Напишите программу, которая на 
вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
`1 4 7 2`
`5 9 2 3`
`8 4 2 4`
`17 -> такого числа в массиве нет` */
while (true)
{
    Console.Clear();
try{
    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = int.Parse(Console.ReadLine());


    int[,] array = FillArray(rowCount, columnCount, 1, 10);
    PrintArray(array);
    
    Console.WriteLine("Введите номер элемента массива");
   int positionInMatrix = int.Parse(Console.ReadLine());
    if (positionInMatrix <=rowCount*columnCount)
        Console.WriteLine ($"В позиции {positionInMatrix} содержится {PosOfMatrix(array,positionInMatrix, rowCount,columnCount)}");
    else
        Console.WriteLine("Такого элемента нет");
}
catch 
{Console.WriteLine("Ошибка ввода");}
    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
}
int PosOfMatrix(int [,] tempArray, int position, int rowCount, int columnCount)
{
    int k=0;
    int tempPos = 0;
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
           k++;
         Console.WriteLine(k);
        Console.WriteLine(position);
                if (position == k)
                tempPos = tempArray[i,j];
        }
        
    }
    return tempPos;
}

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