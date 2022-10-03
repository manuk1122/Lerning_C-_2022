/* # Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
## Дополнительная задача (задача со звёздочкой): 
Задайте одномерный массив, заполненный случайными числами.
 Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов 
 входного массива. Найдите ср. арифметическое из полученных значений элементов массивов 
 и выведите результат сравнения средних арифметических.
`[1,2,3,4] ->
 средн. арифм. значений элементов массива с чётными числами 
 > средн. арифм. значений элементов с нечётными числами`
`[2,3,5,7] -> 
средн. арифм. массива значений элементов с нечётными числами
 > средн. арифм. значений элементов с чётными числами`
`[1,2,5,4] -> 
средн. арифм. значений элементов массива с нечётными числами
 = средн. арифм. значений элементов с чётными числами` */


// метод заполнения массива случайными числами
// метод заполнения массива
//при отрицательном размере массива число проходит модуль
// при левой границе больше правой границы меняются местами
void FillArray(int[] collection, int min, int max)
{

    int length = collection.Length;
    int index = 0;
    int swap = max;
    if (min > max)
    {
        swap = min;
        min = max;
    }
    while (index < length)
    {
        collection[index] = new Random().Next(min, swap);
        index++;
    }
}
// метод поиска исключений
bool Except(string StrN)
{
    bool flag = false;
    // обработка  введеной пустой строки, символа или 0
    flag = int.TryParse(StrN, out int x);
    if (String.IsNullOrEmpty(StrN) | flag == false)
        Console.WriteLine("Введена пустая строка, символ или 0");
    return flag;
}
// метод  отделения четных чисел
int[] SplitOdd(int[] col)
{
    int index = 0;
    int[] OddArray = new int[col.Length];
    while (index < col.Length)
    {
        if (col[index] % 2 == 0)
        {
            OddArray[index] = col[index];
            index++;
        }
        else
            index++;
    }
    return OddArray;
}
// метод отделения нечетных чисел
int[] SplitEven(int[] col)
{
    int index = 0;
    int[] EvenArray = new int[col.Length];
    while (index < col.Length)
    {
        if (col[index] % 2 != 0)
        {
            EvenArray[index] = col[index];
            index++;
        }
        else
            index++;
    }
    return EvenArray;
}
// среднее арифметическое
double AverageOfArray(int[] TempArray, int size)

{
    double averageOfArray = 0;
    for (int i = 0; i < TempArray.Length; i++)

    {
        averageOfArray += TempArray[i];
    }
    return averageOfArray / size;

}
void PrintArray(int[] col)
{
    int index = 0;
    Console.Write("[ ");
    while (index < col.Length)
    {
        Console.ForegroundColor = index % 2 == 0 ? ConsoleColor.Red : ConsoleColor.Green;
        Console.Write(col[index] + ", ");
        index++;
    }
    Console.Write("]");
    Console.WriteLine();
}
//метод поиска количества четных элементов 
int QuantityOdd(int[] array)
{
    int quant = 0; int count = 0;
    while (count < array.Length)
    {
        quant = array[count] % 2 == 0 ? quant + 1 : quant + 0;
        count++;
    }
    return quant;
}
//метод поиска количества нечетных элементов 
int QuantityEven(int[] array)
{
    int quant = 0; int count = 0;
    while (count < array.Length)
    {
        quant = array[count] % 2 != 0 ? quant + 1 : quant + 0;
        count++;
    }
    return quant;
}

while (true)
{
    Console.ResetColor(); 
    Console.Clear();
    Console.WriteLine("Введите размер  массива");
    string TempSize = Console.ReadLine();
    Console.WriteLine("Введите левую  границу массива");
    string TempMin = Console.ReadLine();
    Console.WriteLine("Введите правую границу массива");
    string TempMax = Console.ReadLine();

    if (Except(TempSize) == true &
        Except(TempMin) == true &
        Except(TempMax) == true)
    {
        int[] ArrayOfRanum = new int[Math.Abs(int.Parse(TempSize))];
        FillArray(ArrayOfRanum, int.Parse(TempMin), int.Parse(TempMax));
        PrintArray(ArrayOfRanum);

        //Console.WriteLine(QuantityEven(ArrayOfRanum));
        // Console.WriteLine(QuantityOdd(ArrayOfRanum));

        Console.Write("Массив четных");
        PrintArray(SplitOdd(ArrayOfRanum));
        Console.Write("Массив нечетных");
        PrintArray(SplitEven(ArrayOfRanum));

        Console.WriteLine("Среднее четных " + AverageOfArray(SplitOdd(ArrayOfRanum), QuantityOdd(ArrayOfRanum)));
        Console.WriteLine("Среднее нечетных " + AverageOfArray(SplitEven(ArrayOfRanum), QuantityEven(ArrayOfRanum)));


        if (AverageOfArray(SplitOdd(ArrayOfRanum), QuantityOdd(ArrayOfRanum))
            > AverageOfArray(SplitEven(ArrayOfRanum), QuantityEven(ArrayOfRanum)))
            Console.WriteLine("Средее арифметическое четных > Среднего арифметическое нечетных  ");
        else if (AverageOfArray(SplitOdd(ArrayOfRanum), QuantityOdd(ArrayOfRanum))
            < AverageOfArray(SplitEven(ArrayOfRanum), QuantityEven(ArrayOfRanum)))
            Console.WriteLine("Средее арифметическое нечетных > Среднего арифметическое четных  ");
        else
            Console.WriteLine("Средее арифметическое четных = Среднему арифметическому нечетных");


    }
        Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;

    }