/* Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */


 Console.Clear();
bool flag = false;

Console.WriteLine("введите число для проверки наличия в массиве");
 int a = int.Parse(Console.ReadLine());
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
    {if (a == array[i])
         flag =true;
    }
    if (flag == true)
    Console.WriteLine(a + "; -> ["+ String.Join(",", array)+ "] да");
    else
    Console.WriteLine(a+"; -> ["+ String.Join(",", array)+ "] нет");

/* 
Console.WriteLine("\nПоиск числа в массиве:\n");

int arr_length = 5;

Console.WriteLine("\nВведите число: ");
int num  = Convert.ToInt32(Console.ReadLine());

int[] filledArray1 = FillArray(arr_length, -10, 10);

Console.WriteLine("\nМассив: ");
PrintArray(filledArray1);
Console.WriteLine(SearchNum(filledArray1, num) ? "\n Да" : "\n Нет");

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

bool SearchNum(int[] arr, int search_num)
{
    for (int i = 0; i < arr_length; i++)
    {
        if (arr[i] == num)
        {
            return true;
        }
    }    
    return false;
 */