/* # Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y =  k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.`

`b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)` */

void FillArray(double[] collection)
{
    Console.WriteLine("Заполнение с клавиатуры");
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine($"Введите коэффициенты");
        collection[index] = Convert.ToDouble((Console.ReadLine()));
        index++;
    }
}
while(true)
{
    double[] ArrayOfRanum = new double[4];
    Console.WriteLine("Для определения места пересечения прямых вам необходимо записать их коэффициенты");
    Console.WriteLine("Последовательно введите коэффициенты k1,b1,k2,b2");
try
{
FillArray(ArrayOfRanum); 

double y = 0;
double x = 0;

Console.WriteLine($"k1 = {ArrayOfRanum[0]} ; k2 = {ArrayOfRanum[2]} ");
Console.WriteLine($"b1 = {ArrayOfRanum[1]} ; b2 = {ArrayOfRanum[3]} ");
if (ArrayOfRanum[0]*ArrayOfRanum[3] !=ArrayOfRanum[2]*ArrayOfRanum[1] )
{
 Console.WriteLine("Решение");   
x = (ArrayOfRanum[3]-ArrayOfRanum[1])/(ArrayOfRanum[0]-ArrayOfRanum[2]);
y = ArrayOfRanum[0]*x+ArrayOfRanum[1];
Console.WriteLine($"Пересекутся в ({x},{y})");

}
else
Console.WriteLine("Параллельны");
}
catch
{
Console.WriteLine("Ошибка ввода значения");
}
Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
}