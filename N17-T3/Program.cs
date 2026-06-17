//// DateTime haqida
//DateTime now = DateTime.Now;
//Console.WriteLine(now);

//DateTime utcNow = DateTime.UtcNow;
//Console.WriteLine(utcNow);

//DateTime today = DateTime.Today;
//Console.WriteLine(today);

//DateTime maxVal = DateTime.MaxValue;
//Console.WriteLine(maxVal);

//DateTime minVal = DateTime.MinValue;
//Console.WriteLine(minVal);

//// Qo'lda yaratish or yozish
//DateTime birthday = new DateTime(2010, 1, 18);          // faqat sana bilan
//DateTime birthday1 = new DateTime(2010, 1, 15, 2, 30, 0);   // sana+vaqt
//DateTime birthday2 = new DateTime(2009, 9, 17, 15, 30, 0, 500); // sana+vaqt+millisekund

//// Xususiyatlari
//DateTime dt = new DateTime(2002, 12, 23, 13, 12, 0);

//Console.WriteLine(dt.Year); // 2002
//Console.WriteLine(dt.Month);// 12
//Console.WriteLine(dt.Day);  // 23
//Console.WriteLine(dt.Hour); // 13
//Console.WriteLine(dt.Minute);//12
//Console.WriteLine(dt.Second);//0
//Console.WriteLine(dt.DayOfWeek); // dushanba
//Console.WriteLine(dt.DayOfYear); // 353

//// Add qilishlar
//DateTime order = DateTime.UtcNow;

//DateTime tomorrow = order.AddDays(1);
//DateTime nextMonth = order.AddMonths(1);
//DateTime nextYear = order.AddYears(1);
//DateTime inTwoHours = order.AddHours(2);
//DateTime earlier = order.AddMinutes(-30);







