// Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
Console.WriteLine("Введите число от 1 до 7");
int WeekDay = int.Parse(Console.ReadLine());
if (WeekDay < 1)
{
    Console.WriteLine("Вы ввели неверное значение");
}
else if(WeekDay > 7)
{
    Console.WriteLine("Вы ввели неверное значение");
}
else if(WeekDay == 1)
{
    Console.WriteLine("1 -> понедельник");
}
else if(WeekDay == 2)
{
    Console.WriteLine("2 -> вторник");
}
else if(WeekDay == 3)
{
    Console.WriteLine("3 -> среда");
}
else if(WeekDay == 4)
{
    Console.WriteLine("4 -> четверг");
}
else if(WeekDay == 5)
{
    Console.WriteLine("5 -> пятница");
}
else if(WeekDay == 6)
{
    Console.WriteLine("6 -> суббота");
}
else if(WeekDay == 7)
{
    Console.WriteLine("7 -> воскресенье");
}