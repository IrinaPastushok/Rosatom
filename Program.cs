using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace kahaton3
{
class Program
{
public sealed class DateAndTime { }
static int GetRandom(int a, int b) //функция дающая случайное значение
{
//Создание объекта для генерации чисел (с указанием начального значения)
Random rnd = new Random();

//Получить случайное число
int value = rnd.Next(a, b);

//Вернуть полученное значение
return value;
}

static void Main(string[] args)
{
Console.WriteLine("test");
int r = GetRandom(-30, 40); // случайная начальная темпа
int a = 0; // Некое число от которого зависит колебание температуры
int e = 0; // число "отвечает чтобы данные передовались не каждые 0,5 сек, потому что температура так не скачит, а каждые 5 сек
int colour = 0; // цвет нашей комнаты
int time = 0; // переменная для времени
int light = 0; // яркость света нашей комнаты

while (true)
{
a = GetRandom(-3, 3);
r += a;
if (r > 40) r = 40;
if (r < -30) r = 30;
Console.WriteLine("{0}", r); // ну чисто посмотреть что там, интереса ради
Thread.Sleep(100); //Sleep(500);// здесь указано время задержки в миллисекундах, тоесть наша задержка 0,5 сек, потому что время отклика 0,5 по заданию

e++;
if (e == 10)
{ // когда пройдет 5 секунд произойдет проверка цвета нашего помещения и проверка времени
if (r > 20) { colour = 1; Console.WriteLine("red\n\n"); }
else if (r > 0) { colour = 2; Console.WriteLine("yellow\n\n"); }
else { colour = 3; Console.WriteLine("blue\n\n"); }
e = 0;
colour = 0;


DateTime dt = new DateTime(); // работа со временем дня
dt = DateTime.Now;
time = dt.Hour;
if (time > 18) { Console.WriteLine("evening\n\n"); }
else if (time > 12) { Console.WriteLine("afternoon\n\n"); }
else if (time > 6) { Console.WriteLine("morning\n\n"); }
else { Console.WriteLine("night\n\n"); }
}

}
}
}

}
