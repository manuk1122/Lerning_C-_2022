/* ## Задача 15: Напишите программу, которая принимает 
на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
` 6 -> да `
` 7 -> да `
` 1 -> нет ` */
while (true)
{
    Console.Clear();
    bool flag = false;
    string[] DayOfWeek = {"Понедельник", "Вторник", "Среда",
                        "Четверг", "Пятница", "Суббота", "Воскресенье"};
    Console.WriteLine("Введите день недели для проверки выходного дня");
    string StrNumber = Console.ReadLine();
    flag = int.TryParse(StrNumber, out int x); // попытка конвертировать строку в число
    if (String.IsNullOrEmpty(StrNumber) | flag == false) // обработка на пустую строку или введный символ
        Console.WriteLine("Введена пустая строка или символ ");
    else
    // обработка алгоритма поиска 3-й цифры числа
    {
        int Number = int.Parse(StrNumber);
        if (Number < 8)
        {
            if (Number > 5)
                Console.WriteLine($"{DayOfWeek[Number - 1]} - Выходной день");
            else
                Console.WriteLine($"{DayOfWeek[Number - 1]} - Рабочий день");
        }
        else
            Console.WriteLine("Введено число больше значения дня недели ");
    }



    //Обработка повтора или выхода из алгоритма
    Console.WriteLine(); Console.WriteLine("Если хотите повторить нажмите Enter");
    Console.WriteLine("если нет просто введите любой символ");
    string answ = Console.ReadLine();
    if (!String.IsNullOrEmpty(answ)) break;
}
