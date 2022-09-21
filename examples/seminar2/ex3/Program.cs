
while (true) // зацикливание программы для проверки работы
{
    Console.Clear();
    int Number1 = new Random().Next(0, 1025);
    int Number2 = new Random().Next(0, 1552);


    if (Number2 == 0)
        Console.WriteLine("Деление на 0");
    else
    {
        Console.WriteLine($"Число 1: {Number1}");
        Console.WriteLine($"Число 2: {Number2}");

        int result = 0;
        if (result == Number1 % Number2)
            Console.WriteLine($"Число {Number1} кратен числу {Number2}");
        else
            Console.WriteLine($"остатот от деления равен {Number1 % Number2}");
    }
    /* повтор кода */
    Console.WriteLine("Если хотите повторить нажмите Enter");
    /* условие выхода из кода */
    Console.WriteLine("если нет просто введите любой символ");
    string answ = Console.ReadLine();
    if (!String.IsNullOrEmpty(answ))
        break;
}