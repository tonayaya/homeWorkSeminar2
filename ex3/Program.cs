// Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
//   6 -> да
//   7 -> да
//   1 -> нет

Console.Write("Введите число дня недели: ");
int num_ned = Convert.ToInt32(Console.ReadLine());
if (num_ned >= 1 && num_ned <= 7)
{
    if (num_ned >=1 && num_ned <=5) Console.WriteLine("Указанный день не является выходным днём недели.");
    else Console.WriteLine("Указанный день считается выходным днём недели.");
}
else Console.WriteLine("Введено недопустимое значение!");