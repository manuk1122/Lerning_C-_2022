/* ## Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
`452 -> 11`
`82 -> 10`
`9012 -> 12` */

// Метод для Заполнение массива цифрами числа
void FillArray(int[] collection, int number)
{
    int n = 1;
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = number / n % 10; // отделение цифр
        index++;
        n *= 10;
    }
}
// Метод печати массива из цифр площади 
void PrintArray(int[] col)
{
    int index = 0;
    while (index < col.Length)
    {
        Console.Write(" " + col[index]);
        index++;
    }
    Console.WriteLine();
}
//Метод  нахождения суммы массива
int SumOfDigNum(int[] array)

{
    int sum = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
        sum = sum + array[i];
    return sum;
}
// Метод исключений 
bool Except(string StrN)
{
    bool flag = false;
    // обработка  введеной пустой строки, символа или 0
    flag = int.TryParse(StrN, out int x);
    if (String.IsNullOrEmpty(StrN) | flag == false)
        Console.WriteLine("Введена пустая строка, символ или 0");
    return flag;
}

while (true)
{
    Console.Clear();
    Console.WriteLine("Введите число для нахождения суммы его цифр");
    string StrNumber = Console.ReadLine();
    int[] ArrayOfRanNum = new int[StrNumber.Length];
    if (Except(StrNumber) == true)
    {
        FillArray(ArrayOfRanNum, int.Parse(StrNumber));
        //PrintArray(ArrayOfRanNum); //печать массива для проверки
        Console.WriteLine($"Сумма элементов числа {StrNumber} = {SumOfDigNum(ArrayOfRanNum)}");
    }

    Console.Write("<Enter  продолжение>  <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
}