int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
Console.Clear();

int[] Array = {1, 2, 43, 14, 25, 227, 800, 19, 225 };// добавлен массив
Console.WriteLine(Max
(Max(Array[0],Array[1],Array[2]),
Max(Array[3],Array[4],Array[5]),
Max(Array[6],Array[7],Array[8])));






