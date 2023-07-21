/*Задание 6
Пользователь вводит с клавиатуры показания тем-
пературы. В зависимости от выбора пользователя про-
грамма переводит температуру из Фаренгейта в Цельсий
или наоборот.
*/


Console.WriteLine("Выберите систему перевода температуры");
Console.WriteLine("из шкалы Фарингейте в шкалу Цельсия, нажмите цифру '1' ");
Console.WriteLine("из шкалы Цельсия в шкалу Фарингейта, нажмите цифру '2' ");
var _select = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите температуру :");
double _temp = Convert.ToDouble(Console.ReadLine());
if (_select== 1 & _temp < -459.67) { Console.WriteLine("Не корректные данные!"); }
else if (_select== 2 & _temp < -273.15) { Console.WriteLine("Не корректные данные!"); }
else if (_select == 1)
{
    _temp = (_temp - 32) * 5 / 9;
    Console.WriteLine($"Темпиратура по шкале Цельсия = {_temp}");
}
else 
{
    _temp = _temp* 9 / 5 + 32;
    Console.WriteLine($"Темпиратура по шкале Фарингейта = {_temp}");
}