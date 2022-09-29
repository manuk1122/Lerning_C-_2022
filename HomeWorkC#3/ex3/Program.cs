/* Напишите программу, которая на вход
 принимает радиус круга и находит его 
 площадь округленную до целого числа, необходимо 
 вывести максимальную цифру в полученном 
 округлённом значении площади круга.**

`10 -> 4`
`20 -> 6`
`30 -> 8` */

while (true)
{
    Console.Clear();
    bool flag= false;
    Console.WriteLine("Введите радиус окружности для поиска площади круга");
    double CircSquare = 0;
    string StrCircSq= Console.ReadLine();

    // обработка  введеной пустой строки, символа или 0
    flag = int.TryParse(StrCircSq , out int x);
    if (String.IsNullOrEmpty(StrCircSq) | flag == false)
        Console.WriteLine("Введена пустая строка, символ или 0 ");
    else
    {
        CircSquare = (Math.PI*Math.Pow(int.Parse(StrCircSq), 2));
        int a = (int) CircSquare; // преобразование к целому числу без остатка
        string A = a.ToString(); // преобразование в строку для определение длины

        Console.WriteLine();

        Console.WriteLine($"Окргуленное значение площади {a}");
        Console.Write($"Площадь круга радиусом {int.Parse(StrCircSq)}");
        Console.WriteLine($" = {CircSquare}");
       // Console.WriteLine(Numbers(a));


        int[] ArrayOfRanNum = new int[A.Length]; // определение длины числа через длину строки 
        FillArray(ArrayOfRanNum,a);
        PrintArray(ArrayOfRanNum);
        Console.WriteLine();
        int maxDig = ArrayOfRanNum[0];  // максимальный элемент
        int pos = 0;
        // цикл поиска максимального элемента
            for (int i = 1; i < ArrayOfRanNum.Length; ++i)
                if (ArrayOfRanNum[i] > maxDig) 
                {
                    maxDig = ArrayOfRanNum[i]; pos = i+1;
                }

        Console.WriteLine("Максимальный элемент= " + maxDig);
        Console.WriteLine("Номер элемент= " + pos);
    }
       
        Console.WriteLine();

        Console.WriteLine("Если хотите повторить нажмите Enter");
        Console.WriteLine("если нет просто введите любой символ");
        string answ = Console.ReadLine();
        if (!String.IsNullOrEmpty(answ))
            break;
}

// Метод для Заполнение массива цифрами числа из Площади
 void FillArray(int[] collection, int number)
{
    int n = 1;
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = number/ n %10; // отделение чифр
        index++;
        n *=10; 
    }
} 
// Метод печати массива из цифр площади 
void PrintArray(int[] col)
{
    int index = 0;
    while(index < col.Length)
    {
    Console.Write(" " + col[index]);
    index++;
    }

}