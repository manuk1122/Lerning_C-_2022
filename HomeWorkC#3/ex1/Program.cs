/* *Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.*
`14212 -> нет`
`12821 -> да`
`23432 -> да` */
/* Программа для вывода таблицы квадратов числа N
 */
while (true)
{
    Console.Clear();
    bool flag= false;
    Console.WriteLine("Введите 5 - ти значное число для проверки на полиндром");
    
    string StrN= Console.ReadLine();
    // обработка  введеной пустой строки, символа или 0
    flag = int.TryParse(StrN, out int x);
    if (String.IsNullOrEmpty(StrN) | flag == false  | int.Parse(StrN) == 0 )
        Console.WriteLine("Введена пустая строка, символ или 0 ");
    else
    {
        if (
            // проверка на количество знаков
            int.Parse(StrN)/10 > 1000 & 
            int.Parse(StrN)/10 < 10000
            ) 
        {
          if 
          (
            // решение через сравнение первой с последней цифрой, второй с предпоследней 
                int.Parse(StrN) /10000 == int.Parse(StrN) % 10 &&
                int.Parse(StrN) /1000 % 10 == int.Parse(StrN) /10 % 10 
          )
            Console.WriteLine($"{int.Parse(StrN)} -> да");
          else
            Console.WriteLine($"{int.Parse(StrN)} ->  нет");
        }
       else
       Console.WriteLine("Введено число не соответствующее условию");

}
 Console.WriteLine();
        Console.WriteLine("Если хотите повторить нажмите Enter");
        Console.WriteLine("если нет просто введите любой символ");
        string answ = Console.ReadLine();
        if (!String.IsNullOrEmpty(answ))
            break;
}