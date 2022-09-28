/* Программа вычисления длины отрезка по координатам
 */
while (true)
{
    Console.Clear();
    bool flagAx = false;
    bool flagAy = false;
    bool flagBx = false;
    bool flagBy = false;

    Console.WriteLine("Введите координаты (X,Y) точки А ");
    string StrAx= Console.ReadLine();
    string StrAy= Console.ReadLine();
    Console.WriteLine("Введите координаты (X,Y) точки B ");
    string StrBx= Console.ReadLine();
    string StrBy= Console.ReadLine();
    Console.WriteLine($"Вы ввели B({StrAx},{StrAy})");
    Console.WriteLine($"Вы ввели B({StrBx},{StrBy})");

    
    flagAx = int.TryParse(StrAx, out int x);
    flagAy = int.TryParse(StrAy, out int x1);
    flagBx = int.TryParse(StrBx, out int x2);
    flagBy = int.TryParse(StrBy, out int x3);

    if (
        String.IsNullOrEmpty(StrAx) | flagAx == false |
        String.IsNullOrEmpty(StrAy) | flagAy == false |
        String.IsNullOrEmpty(StrBx) | flagBx == false |
        String.IsNullOrEmpty(StrBy) | flagBy == false)
        Console.WriteLine("Введена пустая строка или символ ");
    
    else 
    
    {   int CordAx = int.Parse(StrAx);
        int CordAy = int.Parse(StrAy);
        int CordBx = int.Parse(StrBx);
        int CordBy = int.Parse(StrBy);
        double AB = Math.Sqrt
            (
            Math.Pow((CordAx - CordBx),2) +  
            Math.Pow((CordAy - CordBy),2)
            );
        Console.WriteLine($"Длинна отрезка АВ = {AB}");
    }
        Console.WriteLine();
        Console.WriteLine("Если хотите повторить нажмите Enter");
        Console.WriteLine("если нет просто введите любой символ");
        string answ = Console.ReadLine();
        if (!String.IsNullOrEmpty(answ))
            break;
}