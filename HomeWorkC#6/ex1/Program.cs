/* # Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

`0, 7, 8, -2, -2 -> 2`

`1, -7, 567, 89, 223-> 3` */
//Заполнение массива с клавиатуры
void FillArray(int[] collection)
{
    Console.WriteLine("Заполнение с клавиатуры");
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine($"Введите {index}-й элемент массива");
        collection[index] = int.Parse(Console.ReadLine());
        index++;
    }
}
// печать массива
void PrintArray(int[] col)

{
    int index = 0;
    Console.Write("[ ");
    while (index < col.Length)
    {
        Console.Write(col[index] + ", ");
        index++;
    }
    Console.Write("]");
    Console.WriteLine();
}
//поиск элементов больше 0
int NumberOfPos(int[] tempArray)
{
    int count = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] > 0)
            count++;
    }
    return count;
}

while (true)
{
    try{
    Console.Clear();
    int size = new Random().Next(1, 5);
    Console.WriteLine("Создан массив размером " + size);
    int[] ArrayOfRanum = new int[size];

    FillArray(ArrayOfRanum);
    PrintArray(ArrayOfRanum);

    Console.WriteLine("Количество элементов больше 0 = "+NumberOfPos(ArrayOfRanum));
    
     }
     catch
    {Console.WriteLine("ошибка ввода");}
    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
}