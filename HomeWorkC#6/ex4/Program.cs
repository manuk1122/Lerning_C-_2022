/* # Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача 2 (задача со звёздочкой): 
Напишите программу, которая задаёт массив из n элементов, 
которые необходимо заполнить случайными значениями 
и определить существует ли пара соседних элементов с одинаковыми значениями,
 при наличии такого элемента заменить его на уникакальное значение.

`[1,2,3,3] -> [1,2,3,4]` */

// метод заполнения массива случайными числами
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
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
        Console.Write(col[index] + " ");
        index++;
    }
    Console.Write("]");
    Console.WriteLine();
}
// метод смены знаения элемента 
int[] ChangeElementOfArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            array[i + 1] = new Random().Next(10, 100);
        }

    }

    return array;
}


while (true)
{
    Console.Clear();
    int size = new Random().Next(4, 5);
    Console.WriteLine("Создан массив размером " + size);
    int[] ArrayOfRanum = new int[size];

    FillArray(ArrayOfRanum);
    PrintArray(ArrayOfRanum);
    // печать с заменой одинаковых значений
    PrintArray(ChangeElementOfArray(ArrayOfRanum));

    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;

}