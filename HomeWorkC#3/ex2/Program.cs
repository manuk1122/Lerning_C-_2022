/* *Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние 
между ними в 3D пространстве.*
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
while (true)
{
    Console.Clear();
    bool flagAx = false; bool flagBx = false;
    bool flagAy = false; bool flagBy = false;
    bool flagAz = false; bool flagBz = false;


    Console.WriteLine("Введите координаты (X,Y,Z) точки А ");
    string StrAx = Console.ReadLine();
    string StrAy = Console.ReadLine();
    string StrAz = Console.ReadLine();

    Console.WriteLine("Введите координаты (X,Y,Z) точки B ");
    string StrBx = Console.ReadLine();
    string StrBy = Console.ReadLine();
    string StrBz = Console.ReadLine();

    Console.WriteLine($"Вы ввели A({StrAx},{StrAy}, {StrAz})");
    Console.WriteLine($"Вы ввели B({StrBx},{StrBy}, {StrBz})");


    flagAx = int.TryParse(StrAx, out int x); flagBx = int.TryParse(StrBx, out int x3);
    flagAy = int.TryParse(StrAy, out int x1); flagBy = int.TryParse(StrBy, out int x4);
    flagAz = int.TryParse(StrAz, out int x2); flagBz = int.TryParse(StrBz, out int x5);
    if (
        String.IsNullOrEmpty(StrAx) | flagAx == false |
        String.IsNullOrEmpty(StrAy) | flagAy == false |
        String.IsNullOrEmpty(StrAz) | flagAz == false |
        String.IsNullOrEmpty(StrBx) | flagBx == false |
        String.IsNullOrEmpty(StrBy) | flagBy == false |
        String.IsNullOrEmpty(StrBz) | flagBz == false)
        Console.WriteLine("Введена пустая строка или символ ");

    else

    {
        int CordAx = int.Parse(StrAx); int CordBx = int.Parse(StrBx);
        int CordAy = int.Parse(StrAy); int CordBy = int.Parse(StrBy);
        int CordAz = int.Parse(StrAz); int CordBz = int.Parse(StrBz);
        double AB = Math.Sqrt
            (
            Math.Pow((CordAx - CordBx), 2) +
            Math.Pow((CordAy - CordBy), 2) +
            Math.Pow((CordAz - CordBz), 2)
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