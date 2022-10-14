/* # Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача (задача со звёздочкой): Задайте двумерный массив из целых чисел. 
Определите, есть столбец в массиве, сумма которого, больше суммы
 элементов расположенных в четырех "углах" двумерного массива.
`Например, задан массив:`
`4 4 7 5`
`4 3 5 3`
`8 1 6 8 -> нет`

`2 4 7 2`
`4 3 5 3`
`2 1 6 2 -> да` */

while(true)
{
Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

int [,] array = FillArray(rowCount, columnCount);
PrintArray(array);
int summOfAngle = 0;

summOfAngle = array[0,0]+(array[0, array.GetLength(0)-1])+ array[array.GetLength(1)-1,0]+array[array.GetLength(0)-1, array.GetLength(1)-1];
for (int i = 1; i <= rowCount; i++)
{       Console.WriteLine(Middle(array,i,rowCount));
        Console.ReadLine();
    if (Middle(array,i,rowCount) > summOfAngle)
    {
        Console.WriteLine("да");
    }
    else 
        Console.WriteLine("нет");
}


Console.WriteLine(summOfAngle);

Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
}





int  Middle(int[,] TempArray, int column, int rows)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += TempArray[i, column - 1];
    }
    return sum;
}



int[,] FillArray(int rows, int columns)
{
    Random rand = new Random(DateTime.Now.Millisecond);
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] =new Random().Next(0,10);
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
            Console.Write(" [" + inputArray[i, j]+" ]");
        }
        Console.WriteLine();
    }
}