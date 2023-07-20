/* Пользователь вводит с клавиатуры число в диапа-
зоне от 1 до 100. Если число кратно 3 (делится на 3 без
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
вывести само число.
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке.
*/

int a;
Console.WriteLine("Введите число от 1 до 100");
a = Convert.ToInt32(Console.ReadLine());
if(a< 1 || a> 110) {Console.WriteLine("Error, number out of range!!!");}
else if(a%3 == 0 && a%5 == 0) {Console.WriteLine("FizzBuzz!");}
else if(a%3 == 0 ) {Console.WriteLine("Fizz!");}
else if(a%5 == 0 )              {Console.WriteLine("Buzz!");}
else  {Console.WriteLine($"Вы ввели число: {a}"); }




//do
//{
//} while (a!= 111);

