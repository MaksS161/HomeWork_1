/*Задание 7
Пользователь вводит с клавиатуры два числа. Нужно
показать все четные числа в указанном диапазоне. Если
границы диапазона указаны неправильно требуется про-
извести нормализацию границ. Например, пользователь
ввел 20 и 11, требуется нормализация, после которой
*/

Console.WriteLine("Введите первое чило :");
var a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чило :");
var b =Convert.ToInt32(Console.ReadLine());
if (a>b) 
{
    int buffer;
    buffer = a;
    a = b;
    b = buffer;
}
for (int i = a; i <= b; i++)
{
    if (i % 2 == 0) { Console.Write($"{i} "); }
}
