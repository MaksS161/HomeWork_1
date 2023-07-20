/*Задание 2
Пользователь вводит с клавиатуры два числа. Первое
число — это значение, второе число процент, который
необходимо посчитать. Например, мы ввели с клавиатуры
90 и 10. Требуется вывести на экран 10 процентов от 90.
Результат: 9.
 */

double  res=0;
Console.WriteLine("Введите Значение: ");
var a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите процент: ");
var procent = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"{procent} процентов от {a}");
Console.WriteLine($"Результат {res = a * procent / 100}");
