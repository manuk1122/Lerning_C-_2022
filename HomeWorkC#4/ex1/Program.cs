/* ## Задача 25: Напишите цикл, который 
принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
`3, 5 -> 243 (3⁵)`
`2, 4 -> 16` 
*/
Console.OutputEncoding = System.Text.Encoding.UTF8;// изменение кодировки консоли
// коды показателей степени в Unicode
string[] ArrayOfExpan = {"\u2070","\u00B9","\u00B2",
                        "\u00B3","\u2074","\u2075",
                        "\u2076","\u2077","\u2078",
                        "\u2079"};
//метод возведения в степень
long GBPow(long number, int exp)

{
    long temp = number;
    while (exp > 1)
    {
        temp = temp * number;
        exp--;
    }
    return temp;
}
//метод форматированного вывода числа возведенного в степень
void PrintNum(long Number, int Expan)
{
    string Temp = "";
    int index = 0;
    if (Expan != 0)
    {
        while (index != Expan)
        {
            Temp = ArrayOfExpan[index + 1];
            index++;
        }
        Console.WriteLine(Number + Temp + " = " + GBPow(Number, Expan));
    }
    else
        Console.WriteLine(Number + ArrayOfExpan[0] + "= 1");

}
//метод поиска исключений
bool Except(string StrN)
{
    bool flag = false;
    // обработка  введеной пустой строки, символа или 0
    flag = int.TryParse(StrN, out int x);
    if (String.IsNullOrEmpty(StrN) | flag == false)
        Console.WriteLine("Введена пустая строка, символ или 0");
    return flag;
}
//выход из цикла по символу

while (true)
{
    Console.Clear();
    Console.WriteLine("Введите число для возведения в степень"); string TNumber = Console.ReadLine();
    Console.WriteLine("Введите степень"); string TExpan = Console.ReadLine();
    if (Except(TNumber) == true & Except(TExpan) == true)
    {   // проверка показателя степени(всего показателей 10 от 0 до 9 для печати в формате 3⁵)
        if (int.Parse(TExpan) >= 10)
        {
            Console.Write($"Число {TNumber} в степени {TExpan} =");
            Console.WriteLine(GBPow(long.Parse(TNumber), int.Parse(TExpan)));
        }
        else
            PrintNum(long.Parse(TNumber), int.Parse(TExpan));
    }
        Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
      if (Console.ReadKey().Key == ConsoleKey.Spacebar) 
        break;  
}
