/* # Задача 54: Задайте двумерный массив. Напишите программу, 
    которая упорядочит по убыванию элементы каждой строки двумерного массива.
`Например, задан массив:`
`1 4 7 2`
`5 9 2 3`
`8 4 2 4`
`В итоге получается вот такой массив:`
`7 4 2 1`
`9 5 3 2`
`8 4 4 2` */
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
// разделение двумерного массива на одномернве и сортиовка каждого с выводом в виде двумерного массива
 void OneArray (int [,] UnsortArray, int rows, int columns)
{
    int [] tempArray = new int [columns];
    for (int j = 0; j < columns; j++)
    {
        tempArray[j] = UnsortArray[rows,j];
        //Console.Write(" "+tempArray[j]);
    }
    Array.Sort(tempArray, (x, y) => y.CompareTo(x));
    for (int i = 0; i < tempArray.Length; i++)
    {
        Console.Write(" " + tempArray[i]);
    }
    Console.WriteLine();
    }



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
    Console.WriteLine();
    
    for (int i =0; i< rowCount; i++)
    OneArray(array,i ,columnCount);
}
catch{Console.WriteLine("Ошибка ввода");}

    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
}