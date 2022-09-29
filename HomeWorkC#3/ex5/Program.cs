/* Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая на вход 
принимает букву, необходимо создать массив из 5 названий городов,
 и вывести на экран те (тот), где чаще всего встречается введённая буква.

`Введённая буква: "о", массив ("Москва", ``"Тюмень", "Новосибирск") -> "Новосибирск"` 
*/
Console.Clear();
Console.WriteLine("Введите букву для вывода города");
char Letter = Convert.ToChar(Console.ReadLine());
string City = ""; // строка для хранения города

string [] ArrayOfCity = {"Краснодар", "Новгород", "Тамбов", "Ялта", "Москва","Воронеж", "Поворино"};
string [] TempArrayOfCity = new string[7];//массив для хранения города(ов) согласно условию 
int tempIndex = 0;
int ab = 0;
int n = 0;
Console.Write("Имеются следующие города: ");
// Печать городов
for (int i =0; i < ArrayOfCity.Length; i++) Console.Write(ArrayOfCity[i]+" ");
Console.WriteLine();

// цикл по городам
for (int ind = 0; ind< ArrayOfCity.Length; ind++)
{
     ab = 0;
    City = ArrayOfCity[ind];
    //Console.WriteLine(City);
    char[] a = City.ToCharArray(); // преобразования строки города в массив символов 
    for (int ind1 = 0; ind1<a.Length; ind1++)
    // учет верхнего и нижнего регистра
        {
        if (a[ind1]== Letter | 
            a[ind1] == Char.ToUpper(Letter) |
            a[ind1] == Char.ToLower(Letter) ) 
            {
            ab = ab + 1;
            if (ab >= 2) 
            {TempArrayOfCity[n] = City;
                n = n+1;}
            }}
        Console.WriteLine($"В городе {City} буква {Letter} встречается {ab} раз"); 
}
Console.Write ($"Буква {Letter} чаще всего встречается в городах :");
for (int ind3 =0; ind3 < n; ind3++)
Console.Write($"{TempArrayOfCity[ind3]} ");
