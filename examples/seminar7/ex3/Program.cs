
// поменять местами первую и последнюю строку массива
/* int [,] ChangeRows (int[,] array)
{
    int[,] changeArray = new int [array.GetLength(0), array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0)-1; i++)
    {
        int temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1, i];
        array[array.GetLength(0)-1, i] = temp;
    }
    return changeArray;
} */
/* 
FillArra(array);
int[,] FillArra(int [,] filladArra)
{

    for (int i = 0; i < filladArra.GetLength(0); i++)
    {
        for (int j = 0; j < filladArra.GetLength(1); j++)
        {
            if (i == 0)
            {
                (filladArra[i, j], filladArra[filladArra.GetLength(1)-1, j]) = (filladArra[filladArra.GetLength(1)-1, j], filladArra[i, j]);
            }
        }
    }
    return filladArra;
}
Console.WriteLine();
PrintArray(array);
 */