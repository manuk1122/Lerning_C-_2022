 Console.WriteLine("\nПоиск числа в массиве:\n");

int arr_length = int.Parse(Console.ReadLine());

int[] filledArray1 = FillArray(arr_length, 1, 10);

Console.WriteLine("\nМассив: ");
PrintArray(filledArray1);
PrintArray(MultPlie(filledArray1));



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

int [] MultPlie(int[] arr)
{ 
    int k = arr_length - 1;
    for (int i = 0; i < arr_length / 2; i++)
    {
        arr[i]= arr[i]*arr[k];
        k--;
}
return arr;
}

 