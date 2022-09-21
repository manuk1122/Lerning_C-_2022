int index = 0;
    
while (true)
{
    index++;
Console.Clear();
int randomNum  = new Random().Next(10,101); // 74
 int a1 = randomNum / 10; // 7 
 int a2 = randomNum % 10; // 4
 int max = a1;
 int i = 0;
 if (a2 > max)
    max  = a2;
if (randomNum == 100)
    {
     i++;
    Console.WriteLine($"ура рэнда {i}");
    }
Console.WriteLine($"max = {max} в числе {randomNum}");
Console.WriteLine($"итерация - {index}");
Console.WriteLine("Если хотите повторить нажмите Enter");
Console.WriteLine("если нет просто введите любой символ");
string answ = Console.ReadLine();
if (!String.IsNullOrEmpty(answ))
    break;
}