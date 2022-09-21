/* ## Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
` 645 -> 5 `
` 78 -> третьей цифры нет `
` 32679 -> 6 `
 */
while (true)
{
    Console.Clear();
    bool flag = false;
    Console.WriteLine("Введите число для 3-й последней цифры");
    string StrNumber = Console.ReadLine();
    int ThirdNum =0;
    flag = int.TryParse(StrNumber, out int x); // попытка конвертировать строку в число

    if (String.IsNullOrEmpty(StrNumber) | flag == false) // обработка на пустую строку или введный символ
        Console.WriteLine("Введена пустая строка или символ ");

    else
// обработка алгоритма поиска 3-й цифры числа
    {
        int Number = int.Parse(StrNumber);
        if (Number <= 999 & Number >= 100)
        {
            ThirdNum = Number % 10;
            Console.WriteLine(ThirdNum);
        }
        else if (Number <= 10000 & Number >= 1000) {ThirdNum = Number / 10 % 10;
                Console.WriteLine(ThirdNum);}
        else if (Number <= 99999 & Number >= 10000) {ThirdNum = Number / 100 % 10;
                Console.WriteLine(ThirdNum);}
        else if (Number <= 999999 & Number >= 100000) {ThirdNum = Number / 1000 % 10;
                Console.WriteLine(ThirdNum);}
        else if (Number <= 9999999 & Number >= 1000000) { ThirdNum = Number / 10000 % 10;
                Console.WriteLine(ThirdNum);}
        else if (Number <= 99999999 & Number >= 10000000) { ThirdNum = Number / 100000 % 10;
                Console.WriteLine(ThirdNum);}
        else if (Number <= 999999999 & Number >= 100000000) { ThirdNum = Number / 1000000 % 10;
                Console.WriteLine(ThirdNum);}
        else
                Console.WriteLine("Нет 3-й цифры");
    }
//Обработка повтора или выхода из алгоритма
        Console.WriteLine(); Console.WriteLine("Если хотите повторить нажмите Enter");
        Console.WriteLine("если нет просто введите любой символ");
        string answ = Console.ReadLine();
        if (!String.IsNullOrEmpty(answ)) break;
}