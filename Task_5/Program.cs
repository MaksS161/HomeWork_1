/*Задание 5
Пользователь вводит с клавиатуры дату. Приложе-
ние должно отобразить название сезона и дня недели.
Например, если введено 22.12.2021, приложение должно
отобразить Winter Wednesday.
 */

Console.Write("Введите день: ");
var _day = Convert.ToInt32(Console.ReadLine());
Console.Write("месяц: ");
var _mon = Convert.ToInt32(Console.ReadLine());
Console.Write("год: ");
var year = Convert.ToInt32(Console.ReadLine());

if (_mon > 12 || _day > 31) { Console.WriteLine("Error, incorrect date"); }
DateTime date = new DateTime(year, _mon, _day);
Console.WriteLine($"День недели -  {date.DayOfWeek}");

if (_mon == 1 || _mon == 2 || _mon == 12) { Console.WriteLine("Время года - Winter"); }
else if (_mon == 3 || _mon == 4 || _mon == 5) { Console.WriteLine("Время года - Spring"); }
else if (_mon == 6 || _mon == 7 || _mon == 8) { Console.WriteLine("Время года - Summer"); }
else { Console.WriteLine("Время года - Autumn"); }


