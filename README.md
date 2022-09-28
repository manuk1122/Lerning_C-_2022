![picture](https://avatars.mds.yandex.net/get-entity_search/5578840/551792258/S122x122Fit_2x)

# Данный репозиторий рассчитан на работу с учебными материалами по языку программирования С#

## Для создания нового консольного приложения используется команда

`dotnet new console`

## Для запуска приложения используется команда

`dotnet run`

## Пользовательские команды для работы с С#

`Console.WriteLine()` - вывод текста на печать

`Console.ReadLine()` - ввод текста
`int num = int.Parse(Console.ReadLine());` - метод int.Parse() превращает строку из терминала в число

`alt+shift+a` - комментирует блок кода

## Обработка введенного значения и зацикливание программы

`while (true)`
`{`
`Console.Clear();`

`bool flag = false;`

`string StrNumber = Console.ReadLine();`

`flag = int.TryParse(StrNumber, out int x); `// попытка конвертировать строку в число

`if (String.IsNullOrEmpty(StrNumber) | flag == false)` // обработка на пустую строку или введный символ

`Console.WriteLine("Введена пустая строка или символ ");`

`else`

`{`

тело программы

`}`

//Обработка повтора или выхода из алгоритма

`Console.WriteLine(); Console.WriteLine("Если хотите повторить нажмите Enter");`

` Console.WriteLine("если нет просто введите любой символ");`

`string answ = Console.ReadLine();`

` if (!String.IsNullOrEmpty(answ)) break;`

## 
