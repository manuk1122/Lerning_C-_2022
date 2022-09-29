/* *Напишите программу, которая принимает на вход число 
(N) и выдаёт таблицу кубов чисел от 1 до N.* 

`3 -> 1, 8, 27`
`5 -> 1, 8, 27, 64, 125`
 */
while (true)
{
    Console.Clear();
    bool flag= false;
    Console.WriteLine("Введите число  N для определения таблицы кубов от 1 до N");
    string StrN= Console.ReadLine();
    flag = int.TryParse(StrN, out int x);

    if (String.IsNullOrEmpty(StrN) | flag == false)
        Console.WriteLine("Введена пустая строка или символ ");
    
    else if (int.Parse(StrN) == 0)
        Console.WriteLine($"Вы ввели {int.Parse(StrN)}");
    else
    {
    int N = int.Parse(StrN);
    int index = 1;
    string StringRes = StrN+ "-> " ;
    while(index <= N )
    {
        // формирование строки для печати
        StringRes += Convert.ToString(Math.Pow(index,3)) +  ", "; 
        index++;        
    }
    // индекс последних 2-х символов
   int endOfString = StringRes.Length - 2; 
    // печать с удаление 2- последних символов
    Console.Write(StringRes.Remove(endOfString));
       
}
 Console.WriteLine();
        Console.WriteLine("Если хотите повторить нажмите Enter");
        Console.WriteLine("если нет просто введите любой символ");
        string answ = Console.ReadLine();
        if (!String.IsNullOrEmpty(answ))
            break;
} 