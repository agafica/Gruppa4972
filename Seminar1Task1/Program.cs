﻿// string day = Console.ReadLine()??"0";

// switch (day)
// {
//     case "1": Console.WriteLine("Понедельник"); break;
//     case "2": Console.WriteLine("Вторник"); break;
//     case "3": Console.WriteLine("Среда"); break;
//     case "4": Console.WriteLine("Четверг"); break;
//     case "5": Console.WriteLine("Пятница"); break;
//     case "6": Console.WriteLine("Суббота"); break;
//     case "7": Console.WriteLine("Воскресенье"); break;
//     default: Console.WriteLine("Неверные данные"); break;
// }


string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum));

Console.WriteLine(outDayOfWeek);