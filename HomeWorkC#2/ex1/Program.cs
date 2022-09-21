/* ## Задача 10: Напишите программу, которая принимает на вход
 трёхзначное число и на выходе показывает вторую цифру этого числа.

` 456 -> 5 `

` 782 -> 8 `

` 918 -> 1 ` */
while (true)
{
    Console.Clear();
    bool flag = false;
    Console.WriteLine("Введите 3-х значное число для поиска средней цифры в диапазоне от 100 до 999");
    string StrNumber = Console.ReadLine();

    flag = int.TryParse(StrNumber, out int x);
    if (String.IsNullOrEmpty(StrNumber) | flag == false)
    {
        Console.WriteLine("Введена пустая строка или символ ");
        Console.WriteLine(flag);
    }
    else
    {
        int Number = int.Parse(StrNumber);
        if (Number <= 999 & Number >= 100)
        {
            int lastNum = Number / 10 % 10;
            Console.WriteLine(lastNum);
        }
        else
            Console.WriteLine("вы ввели число не соответствующее условию");
    }

    Console.WriteLine();
    Console.WriteLine("Если хотите повторить нажмите Enter");
    Console.WriteLine("если нет просто введите любой символ");
    string answ = Console.ReadLine();
    if (!String.IsNullOrEmpty(answ))
        break;
}
