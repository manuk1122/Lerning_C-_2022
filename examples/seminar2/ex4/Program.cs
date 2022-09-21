
while (true) // зацикливание программы для проверки работы
{
    Console.Clear();
    int Number1 = new Random().Next(0, 1025);
    if (Number1 % 7 == 0 && Number1 % 23 == 0 )
        Console.WriteLine($"Число : {Number1} кратно 7 и 23");
        else
        Console.WriteLine($"Число : {Number1} НЕкратно 7 и 23");
    /* повтор кода */
    Console.WriteLine("Если хотите повторить нажмите Enter");
    /* условие выхода из кода */
    Console.WriteLine("если нет просто введите любой символ");
    string answ = Console.ReadLine();
    if (!String.IsNullOrEmpty(answ))
        break;
}