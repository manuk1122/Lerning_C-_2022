//метод для заполнения массива случайными числами от 0 до 10
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
// метод для печати массива
void PrintArray(int[] col)
{
    int index = 0;
    while(index < col.Length)
    {
    Console.WriteLine(col[index]);
    index++;
    }

}

int[] ArrayOfRanNum = new int[99];

FillArray(ArrayOfRanNum);
PrintArray(ArrayOfRanNum);