/* ## Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт
 массив из 10 элементов, которые необходимо заполнить случайными значениями
  в диапазоне от -10 до 10 и найти максимальное значение среди них.

`[-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9`
`[-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6`
`[-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7`
 */
 // метод заполнения массива случайными числами
 void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(-10,11);
        index++;
    }
}
// метод поиска и вывода максимального элемента
void MaxOfArray(int[] TempArray)
{
  int max = TempArray[0];  // максимальный элемент
        int pos = 0;
        // цикл поиска максимального элемента
            for (int i = 1; i < TempArray.Length; ++i)
                if (TempArray[i] > max) 
                {
                    max = TempArray[i]; pos = i+1;
                }
        Console.WriteLine(" "+max);
        Console.WriteLine("Номер элемента = " + pos);
    }



int[] ArrayOfRanNum = new int[10];
while (true)
{
FillArray(ArrayOfRanNum);
Console.Write("["+ String.Join(" , ", ArrayOfRanNum)+ "] ->");
MaxOfArray(ArrayOfRanNum);
Console.Write("<Enter  продолжение>  <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
}

