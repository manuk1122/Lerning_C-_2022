/* # Задача 36: 
## Задайте одномерный массив, заполненный 
случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
`[3, 7, 23, 12] -> 19`
`[-4, -6, 89, 6] -> 0` */
// метод заполнения массива
//при отрицательном размере массива число проходит модуль
// при левой границе больше правой границы меняются местами
void FillArray(int[] collection, int min, int max)
{

    int length = collection.Length;
    int index = 0;
    int swap = max;
    if (min>max)
        {swap = min;
        min =max;}
    
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

// метод цветного отделения четных чисел от нечетных
void PrintArray(int[] col)
{
    int index = 0;
    Console.Write("[ ");
    while (index < col.Length)
    {
       Console.ForegroundColor = index % 2 == 0 ? ConsoleColor.Red : ConsoleColor.Green;
            Console.Write(col[index]+", ");
            index++;
    }
    Console.Write("]");
    Console.WriteLine();
}
//метод поиска суммы элементов нечетных позиций 
int SummOfOddPos(int[] array)
{

    int Odd = 0;
    int count = 0;
    while (count < array.Length)
    {
        Odd = count % 2 == 0 ? Odd + 0 : Odd + array[count];
        count++;
    }
    return Odd;
}

while(true)
    {
    Console.Clear();
    Console.WriteLine("Введите размер  массива");
    string TempSize = Console.ReadLine();
    Console.WriteLine("Введите левую  границу массива");
    string TempMin = Console.ReadLine();
    Console.WriteLine("Введите правую границу массива");
    string TempMax = Console.ReadLine();
    
    if (Except(TempSize)== true & 
        Except(TempMin)== true &
        Except(TempMax)== true )
    {
    int[] ArrayOfRanum = new int[Math.Abs(int.Parse(TempSize))];
    FillArray(ArrayOfRanum,int.Parse(TempMin),int.Parse(TempMax));
    PrintArray(ArrayOfRanum);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Сумма элементов нечетных позиций - > {SummOfOddPos(ArrayOfRanum)}");
    } 
      Console.ResetColor(); 
    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
    
    }