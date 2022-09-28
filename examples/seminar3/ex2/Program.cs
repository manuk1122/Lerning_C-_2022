/* Программа определния диапазона координат по номеру четверти
 */
while (true)
{
    Console.Clear();
    bool flag= false;
    Console.WriteLine("Введите четверть для определения диапазона");
    string StrNumberChet= Console.ReadLine();
    flag = int.TryParse(StrNumberChet, out int x);

    if (String.IsNullOrEmpty(StrNumberChet) | flag == false)
        Console.WriteLine("Введена пустая строка или символ ");
    
    else if (int.Parse(StrNumberChet) == 0 | int.Parse(StrNumberChet) > 4 )
        Console.WriteLine($"Вы ввели {int.Parse(StrNumberChet)}");
    else
    {
    int NumberChet = int.Parse(StrNumberChet);
        if (
            NumberChet  == 1 )
            {
                //Первая четверть
            Console.WriteLine   ("X от 0 до + оо"); 
            Console.WriteLine   ("Y от 0 до + оо");
            }
        else if (
                //Вторая четверть
            NumberChet == 2)
            {
            Console.WriteLine  ("X от - оо до 0 ");
            Console.WriteLine  ("Y от 0 до + оо");
            }
        else if (
            //Третья четверть
            NumberChet == 3)
            {
            Console.WriteLine  ("X  от - оо до 0");
            Console.WriteLine  ("Y  от -оо до 0");
            }
        else
            {
                //Четвертая четверть
            Console.WriteLine   ("X от 0 до + оо");
            Console.WriteLine   ("Y от - оо до 0");
            }
    }
        Console.WriteLine();
        Console.WriteLine("Если хотите повторить нажмите Enter");
        Console.WriteLine("если нет просто введите любой символ");
        string answ = Console.ReadLine();
        if (!String.IsNullOrEmpty(answ))
            break;
}