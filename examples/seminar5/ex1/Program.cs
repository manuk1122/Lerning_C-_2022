/* / Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.
 */
 Console.Clear();
 int [] array = FillArray(12, -9, 9);
 int [] FillArray(int size, int min, int max){
    int [] filledArray = new int[size];
    for(int i = 0; i< filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max+1);
    }
    return filledArray;
 }
 int positiveSum = 0;
 int NegativeSum = 0;
 Console.WriteLine("["+ String.Join(",", array)+ "]"); // форматированный вывод массива 
 foreach(int element in array) // 
 {
    positiveSum +=element >0 ? element : 0; // if (element>0) {positiveSum+=elment else posotove +=0} 
    NegativeSum +=element <0 ? element : 0;
 }
 Console.WriteLine("Сумма положительных = "+ positiveSum);
 Console.WriteLine("Сумма отрицательных = "+ NegativeSum);