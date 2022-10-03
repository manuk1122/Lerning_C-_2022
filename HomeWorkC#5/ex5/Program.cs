/* 
# Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
## Дополнительная задача 2 (задача со звёздочкой): Задайте одномерный массив из N элементов, 
заполненный случайными числами. Необходимо определить, 
в какой последовательности заданы элементы массива: 
по возрастанию,
 по убыванию, хаотично, 
 или все элементы одинаковы.
`[1,2,3,4] -> по возрастанию`
`[4,3,2,1] -> по убыванию`
`[4,2,3,1] -> хаотично`
`[1,1,1,1] -> все элементы равны` */

// метод заполнения массива числами c клавиатуры
void FillArray(int[] collection)
{
    Console.WriteLine("Вы выбрали метод с клавиатуры");
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine($"Введите {index}-й элемент массива");
        collection[index] = int.Parse(Console.ReadLine());
        index++;
    }
}
/* метод заполнения массива случайными числами
при отрицательном размере массива число проходит модуль
 при левой границе больше правой границы меняются местами  */
 void FillRanArray(int[] collection, int min, int max)
{
    Console.WriteLine("Вы выбрали случайный метод");
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
// проверка на порядка : возвращает true если по возрастанию
bool UpSort(int [] array)
{
int count = 1;
int max = array[0];
bool flag = true;
for(int i = 1; i<array.Length; i++) 
{
if (array[i]> max )
{
    count ++;
    max = array[i];
}
}
return count == array.Length ? true:false; 
}
// проверка на порядка : возвращает true если по убыванию
bool DownSort(int [] array)
{
int count = 1;
int min = array[0];
bool flag = true;
for(int i = 1; i<array.Length; i++) 
{
if (array[i]< min )
{
    count ++;
    min = array[i];
}
}
return count == array.Length ? true:false; 
}
// проверка на порядка : возвращает true если все равны
bool EqualSort(int [] array)
{
int count = 1;
int min = array[0];
bool flag = true;
for(int i = 1; i<array.Length; i++) 
{
if (array[i]<= min )
{
    count ++;
    min = array[i];
}
}
return count == array.Length ? true:false; 
}
// печать массива
void PrintArray( int [] col)
{
    int index = 0;
    Console.Write("[ ");
    while (index < col.Length)
    {
            Console.Write(col[index]+", ");
            index++;
    }
    Console.Write("]");
    Console.WriteLine();
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



while(true)
{
    Console.Clear();
 Console.WriteLine("Существует 2 метода заполнения массива с клавиатуры и случайно Нужный раскоментировать");
 Console.WriteLine("Нажмите любую клавишу для продолжения...");
 Console.ReadLine();
 int[] ArrayOfRanum = new int[new Random().Next(1,20)];
FillArray(ArrayOfRanum); // заполненение с клавиатуры
// FillRanArray(ArrayOfRanum,int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));// заполненение случайно
PrintArray(ArrayOfRanum);
Console.WriteLine();
//Console.WriteLine(UpSort(ArrayOfRanum));
//Console.WriteLine(DownSort(ArrayOfRanum));
//Console.WriteLine(EqualSort(ArrayOfRanum));
if (UpSort(ArrayOfRanum) == true) {PrintArray(ArrayOfRanum); Console.WriteLine("-> по возрастанию");}

else if (DownSort(ArrayOfRanum) == true){PrintArray(ArrayOfRanum);Console.WriteLine("-> по убыванию");}

else if (EqualSort(ArrayOfRanum) == true){PrintArray(ArrayOfRanum); Console.WriteLine("-> все элементы равны");}

else {PrintArray(ArrayOfRanum); Console.WriteLine("-> хаотично");}

Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
}