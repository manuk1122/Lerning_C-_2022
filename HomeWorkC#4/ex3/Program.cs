/* ## Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
`1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]`
`6, 1, 33 -> [6, 1, 33]`
 */
 //Метод заполнения массива с клавиатуры
void ArrayFromKeyBord (int[] collection,int size)
{
    int count = 0;
    string temp = "";
    while (count<size)
    {
        
        Console.WriteLine($"Введите {count}-й элемент массива");
        temp = Console.ReadLine();
        if (Except(temp) == true)
            collection[count] = int.Parse(temp);
        count++;
    }


}
// Метод печати массива
void PrintArray(int[] col)

{
    int index = 0;
    while (index < col.Length)
    {
        Console.Write($"[{col[index]} ]");
        index++;
    }
    Console.WriteLine();
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
while(true)
{
    Console.Clear();
Console.WriteLine("Введите размер массива");
string sizeAr = Console.ReadLine();
if (Except(sizeAr) == true)
{
int sizeArint = int.Parse(sizeAr);
int[] ArrayOfRanNum = new int[sizeArint];
ArrayFromKeyBord (ArrayOfRanNum,sizeArint);
Console.WriteLine("["+ String.Join(",", ArrayOfRanNum)+ "]");
}
else
    Console.WriteLine("Попытайтесь вновь ввести количество");
 
 
 Console.WriteLine("<Enter  продолжение>  <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
}