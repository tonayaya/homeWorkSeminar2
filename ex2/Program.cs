// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
//   645 -> 5
//   78 -> третьей цифры нет
//   32679 -> 6


int temp = 1;
Console.Write("Введите целое положительное число: ");
string? num_str = Console.ReadLine();
if (num_str != null)
{
    int num_l = num_str.Length;
    if (num_l > 2) 
    {
        int num = Convert.ToInt32(num_str);
        if (num > 0)
        {
            for (int i = 0; i < num_l - 3; i++) temp *= 10;
            num /= temp;
            num %= 10;
            Console.WriteLine($"Третья цифра в числе {num_str}  равна {num} ");
        }
        else Console.WriteLine("Введено отрицательное числовое значение!");
    }
    else Console.WriteLine($"В числе {num_str} нет третьей цифры!");
}
else Console.WriteLine("Введено неверное числовое значение!");
