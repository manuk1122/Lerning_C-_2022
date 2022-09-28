/* Программа определния плоскости по координате
 */
 while(true)
 {
 Console.Clear();
    bool flagX = false;
    bool flagY = false;
    Console.WriteLine("Введите координату X для поиска четверти");
    string StrNumberX = Console.ReadLine();
    Console.WriteLine("Введите координату Y для поиска четверти");
    string StrNumberY = Console.ReadLine();

    flagX = int.TryParse(StrNumberX, out int x);
    flagY = int.TryParse(StrNumberY, out int y);

    if (String.IsNullOrEmpty(StrNumberX) | flagX == false | String.IsNullOrEmpty(StrNumberY)| flagY == false)
    {
        Console.WriteLine("Введена пустая строка или символ ");
    }
    else
    {
        int NumberX = int.Parse(StrNumberX);
        int NumberY = int.Parse(StrNumberY);
        if (NumberX > 0 && NumberY > 0)
            Console.WriteLine("1 четверть");
        else
            Console.WriteLine("вы ввели число не соответствующее условию");
    }// продолжение следует........

    Console.WriteLine();
    Console.WriteLine("Если хотите повторить нажмите Enter");
    Console.WriteLine("если нет просто введите любой символ");
    string answ = Console.ReadLine();
    if (!String.IsNullOrEmpty(answ))
        break;
        
}
