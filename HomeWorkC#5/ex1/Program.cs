/* # Задача 34: 
## Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет
 количество чётных чисел в массиве.
`[345, 897, 568, 234] -> 2`*/

// метод заполнения массива случайными числами
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}
// метод поиска четных чисел в массиве
int Quantity(int[] array)
{

    int quant = 0;
    int count = 0;
    while (count < array.Length)
    {
        quant = array[count] % 2 == 0 ? quant + 1 : quant + 0;
        count++;
    }
    return quant;
}
// метод цветного отделения четных чисел от нечетных
void PrintArray(int[] col)
{
    int index = 0;
    Console.Write("[ ");
    while (index < col.Length)
    {
       Console.ForegroundColor = col[index] % 2 == 0 ? ConsoleColor.Green : ConsoleColor.Red ;
            Console.Write(col[index]+", ");
            index++;
    }
    Console.Write("]");
    Console.WriteLine();
}

while (true)
{
    Console.Clear();

    int size = new Random().Next(1, 100);// случайный размер
    int[] FirstArray = new int[size];

    FillArray(FirstArray); // заполнение массива
    PrintArray(FirstArray); // печать массива 

    Console.BackgroundColor = ConsoleColor.DarkGreen;
    
    Console.WriteLine("- >" + Quantity(FirstArray));
    Console.ResetColor(); // сбрасываем в стандартный цвет
    Console.BackgroundColor = ConsoleColor.Black;

    Console.ResetColor(); // сбрасываем в стандартный
    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
}