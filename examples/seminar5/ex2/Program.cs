/* Общее обсуждение решения
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
 */
 Console.Clear();
 int [] array = FillArray(12, -9, 9);
 int [] FillArray(int size, int min, int max){
    int [] filledArray = new int[size];
    for(int i = 0; i< filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max+1);
    }
    return filledArray;
 }
 Console.WriteLine("["+ String.Join(",", array)+ "]");
  for (int i = 0; i< array.Length; i++)
    array[i]*=-1;
Console.WriteLine("["+ String.Join(",", array)+ "]");
