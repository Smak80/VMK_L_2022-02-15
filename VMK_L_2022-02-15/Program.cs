// See https://aka.ms/new-console-template for more information

using VMK_L_2022_02_15;

var a = new MyClass();
var b = new MyClass();
Console.WriteLine(a);
Console.WriteLine(a.Equals(b));
var c = a;
Console.WriteLine(c.Equals(a));
Console.WriteLine(a);
a.Day = MyClass.DayOfWeek.Среда;
MyClass d = new MyClass("Привет!");
Console.WriteLine(d[MyClass.DayOfWeek.Суббота]);