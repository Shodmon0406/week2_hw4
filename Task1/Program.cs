﻿Time time = new Time(20, 30, 12);
System.Console.WriteLine(time.Hour);
System.Console.WriteLine(time.Minute);
System.Console.WriteLine(time.Second);
System.Console.WriteLine(time.ToString());
time.SetTime(59, 59, 23);
time.NextSecond();
time.NextSecond();
time.NextSecond();
System.Console.WriteLine(time.ToString());