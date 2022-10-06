/* ## Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая задаёт 
2 одномерных массива из N элементов которые заполняются
 случайными значениями в диапазоне от 1 до 10 
 и находит среднее арифметическое элементов этих 2 массивов, 
 далее от большего из получившихся средних арифметических отнимаем меньшее
  и округлённый до целого числа результат переводим в двоичную систему счисления.
`[1,2,3,4] [3,6,4] -> округлённая до целого числа разница между средними арифметическими массивов = 2. 2
 в двоичной системе счисления = 10`
`[4,7,9] [3,3,1,2,2] -> округлённая до целого числа разница между средними арифметическими массивов = 4. 4
 в двоичной системе счисления = 100` */

 // метод заполнения массива случайными числами
 void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(1,11);
        index++;
    }
}
// проверка значений на допустимые
bool Except(string StrN)
{
    bool flag = false;
    // обработка  введеной пустой строки, символа или 0
    flag = int.TryParse(StrN, out int x);
    if (String.IsNullOrEmpty(StrN) | flag == false)
        Console.WriteLine("Введена пустая строка, символ или 0");
    return flag;
}
// метод поиска среднего арифметического
double AverageOfArray(int [] TempArray)
{
    double averageOfArray = 0;
for (int i = 0; i<TempArray.Length; i++)

{
averageOfArray += TempArray[i]; 
}
return averageOfArray/TempArray.Length;

}
// метод конвертации в двоичный код
string ShowBin(int TempNum)
{
    int rem = 0;
    string result ="";   
    while (TempNum> 0)
    {
    rem = TempNum % 2;
    TempNum= TempNum / 2;
    result = rem.ToString() + result;
    }
    return result;
}
// разность между большим и меньшим значением
double GBAbs(double firstOp, double SecondOp)
    {
        double result = 0;
         result = firstOp>SecondOp ? firstOp -SecondOp : SecondOp -firstOp; 
         return result;
    }
// метод округления
int GBRound(double tempRound)
{
int tempBin = 0;
double tempR = 0;
tempR = (tempRound % 10 >= 5) ? (tempRound /1 + 1 ): (tempRound /1);
tempBin = Convert.ToInt32(tempR);
return tempBin;
}

while(true)
{
    Console.Clear();
Console.WriteLine("Введите размер массива 1");
string TempSize1 = Console.ReadLine();
Console.WriteLine("Введите размер массива 2");
string TempSize2 = Console.ReadLine();

if (Except(TempSize1) == true & Except(TempSize2) == true)
{
    int size1 = int.Parse(TempSize1); int size2 = int.Parse(TempSize2);
    int [] FirstArray = new int [size1]; int [] SecondArray = new int [size2];

    FillArray(FirstArray); FillArray(SecondArray);

    Console.Write("Первый массив ["+ String.Join(" , ", FirstArray)+ "]"); Console.WriteLine();
    Console.Write("Второй массив ["+ String.Join(" , ", SecondArray)+ "]"); Console.WriteLine();
    
    Console.WriteLine($"Среднее арифметическое 1-го массива = {AverageOfArray(FirstArray)} ");
    Console.WriteLine($"Среднее арифметическое 2-го массива = {AverageOfArray(SecondArray)} ");
    Console.Write("Разница средних арифметических массивов = ");
    Console.WriteLine(GBAbs(AverageOfArray(FirstArray),AverageOfArray(SecondArray)));
    
    Console.Write($"Округленное значение ");
    Console.WriteLine($"{GBAbs(AverageOfArray(FirstArray),AverageOfArray(SecondArray))} = {GBRound((GBAbs(AverageOfArray(FirstArray),AverageOfArray(SecondArray))))}");
       
    Console.WriteLine();
    
    Console.WriteLine($"Двоичное представление числа {GBRound((GBAbs(AverageOfArray(FirstArray),AverageOfArray(SecondArray))))} -> {ShowBin(GBRound((GBAbs(AverageOfArray(FirstArray),AverageOfArray(SecondArray)))))}");
    }
    Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
      if (Console.ReadKey().Key == ConsoleKey.Spacebar) 
        break;  
} 