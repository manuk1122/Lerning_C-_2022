/* Прогрмма нахождения элемента
 массива с задаными параметром */
 Console.Clear();
 int[] ArrayOfNums = {1, 2, 3, 4 ,5 ,8 ,6 ,8};
 int n = ArrayOfNums.Length;
 int find = 8;
 int index = 0;
while (index < n)
{
    if (ArrayOfNums[index] == find)
      {    
        Console.WriteLine(index);
       break;// если не будет break то выведутся все номера нужных элементов
        
    }
    index++;
}