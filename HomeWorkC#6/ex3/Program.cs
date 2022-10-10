/* # Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача (задача со звёздочкой): Напишите программу,
 которая задаёт массив из n элементов, которые необходимо заполнить случайными 
значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.
`[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево`
`[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо`
 */

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

void PrintArray(int[] col)
{
    int index = 0;
    Console.Write("[ ");
    while (index < col.Length)
    {
       Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(col[index]+" ");
            index++;
    }
    Console.Write("]");
    Console.WriteLine();
    Console.ResetColor(); 
}
// метод для смещения массива вправо->
int[] shiftRigth (int[] array)
{
int[] swapArray = new int [array.Length];
swapArray[0] = array[array.Length-1];
for(int i = 0; i< (array.Length-1); i++)
{
swapArray[i+1] = array[i];
}

return swapArray;
}
// метод для смещения массива влево <-
int[] shiftLeft (int[] array)
{
int[] swapArray = new int [array.Length];
swapArray[array.Length-1] = array[0];
for(int i = 1 ; i != (array.Length); i++)
{
swapArray[i-1] = array[i];
}

return swapArray;
}


while(true)
{

Console.Clear();
int size = new Random().Next(10, 10);
Console.WriteLine("Создан массив размером " + size);
int[] ArrayOfRanum = new int[size];

FillArray(ArrayOfRanum);//заполняем массив
PrintArray(ArrayOfRanum); //печатаем исходный массив


Console.WriteLine("Смещенный массив вправо-> ");
// смещение вправо исходного массива
PrintArray(shiftRigth(ArrayOfRanum));

Console.WriteLine("Смещенный массив влево-> ");
// смещаем массив влево который получен смещением вправо 
// для простой проверки и получения исходного массива
PrintArray(shiftLeft(shiftRigth(ArrayOfRanum)));

     Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
}
    
  
    