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
    flag = int.TryParse(StrNumber, out int x); // попытка конвертировать строку в число

    if (String.IsNullOrEmpty(StrNumber) | flag == false) // обработка на пустую строку или введный символ
        Console.WriteLine("Введена пустая строка или символ ");

    else
    // обработка алгоритма поиска 3-й цифры числа
    {
        int Number = int.Parse(StrNumber);
        if (Number / 10 > 10) //  определения количества цифр в числе по целому частному(двух и более знаков)
        {
            while (Number / 10 > 99)
            {
                Number /= 10; // то же самое что и Number = Number / 10
            }
            Console.WriteLine(Number % 10);
        }
        else
            Console.WriteLine("Нет 3-й цифры");
    }

    //Обработка повтора или выхода из алгоритма
    Console.WriteLine(); Console.WriteLine("Если хотите повторить нажмите Enter");
    Console.WriteLine("если нет просто введите любой символ");
    string answ = Console.ReadLine();
    if (!String.IsNullOrEmpty(answ)) break;
}