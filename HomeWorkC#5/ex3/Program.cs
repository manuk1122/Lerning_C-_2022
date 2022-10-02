/* # Задача 38: 
## Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
`[3 7 22 2 78] -> 76` */   

//формировка массива через текущее время и 
//явное преобразование  double во float(меньше знаков просто)
void FillArray(float [] collection)
{
    Random rand = new Random(DateTime.Now.Millisecond);
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = (float)(rand.NextDouble()*20);
        index++;
    }
}
// метод печати массива
void PrintArray( float [] col)
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
// метод поиска  минимального элемента
float MinOfArray(float[] TempArray)
{
    float min = TempArray[0];  // максимальный элемент
        // цикл поиска максимального элемента
            for (int i = 1; i < TempArray.Length; ++i)
                if (TempArray[i] < min) 
                {
                    min = TempArray[i];
                }
    return min;
}
// метод поиска максимального элемента
float MaxOfArray(float[] TempArray)
{
  float max = TempArray[0];  // максимальный элемент
        // цикл поиска максимального элемента
            for (int i = 1; i < TempArray.Length; ++i)
                if (TempArray[i] > max) 
                {
                    max = TempArray[i];
                }
    return max;
    }

while(true)
{
    Console.Clear();
    Console.WriteLine(DateTime.Now); //  для формировки слуайного числа используется текущее время

    int size = new Random().Next(4, 10);// случайный размер
    float [] FirstArray = new float[size];

    FillArray(FirstArray); // заполнение массива
    PrintArray(FirstArray); // печать массива 
   Console.ForegroundColor = ConsoleColor.Green;
    
    Console.WriteLine($"Max = {MaxOfArray(FirstArray)}");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Min = {MinOfArray(FirstArray)}");
    Console.ResetColor(); 
    Console.WriteLine($"Max({MaxOfArray(FirstArray)})-Min({MinOfArray(FirstArray)})={MaxOfArray(FirstArray)-MinOfArray(FirstArray)}");
    
   Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        break;
    }