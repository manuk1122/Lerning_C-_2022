/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
*/
int count = 0;
int [] array = FillArray(123, 1, 123);
 int [] FillArray(int size, int min, int max){
    int [] filledArray = new int[size];
    for(int i = 0; i< filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max+1);
    }
    return filledArray;
 }
 Console.WriteLine("["+ String.Join(",", array)+ "]");
for (int i= 0; i< array.Length; i++)
    {if (array[i]>=10 & array[i]<= 99)
        count++;}
Console.WriteLine(count);

/* Console.WriteLine("\nПоиск числа в массиве:\n");

int arr_length = 123;

int[] filledArray1 = FillArray(arr_length, 1, 123);

Console.WriteLine("\nМассив: ");
PrintArray(filledArray1);
Console.WriteLine(SearchNum(filledArray1));

int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];

    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("\n [" + String.Join(",", arr) + "]");
}

int SearchNum(int[] arr)
{ int count = 0;

    for (int i = 0; i < arr_length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            count ++;
        }
    }    
    return count;
}
 */
