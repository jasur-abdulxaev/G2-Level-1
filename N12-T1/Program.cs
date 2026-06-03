// OOP intro
// OOP - object-oriented programming


//// Muammoni ko'ramiz birinchi
//string talaba1Ismi = "Oydinoy";
//int talaba1Yoshi = 17;
//double talaba1Balansi = 50_000.00;

//string talaba2Ismi = "Alijon";
//int talaba2Yoshi = 16;
//double talaba2Balansi = 60_000.00;

//string talaba3Ismi = "Iqbol";
//int talaba3Yoshi = 16;
//double talaba3Balansi = 70_000.00;

//// Faqat ismlarini chiqarib turibmiz
//Console.WriteLine(talaba1Ismi);
//Console.WriteLine(talaba2Ismi);
//Console.WriteLine(talaba3Ismi);


//if (talaba1Balansi > 60_000.00)
//{
//    Console.WriteLine($"{talaba1Ismi}ning balansi 60 mingdan katta");
//}
//else
//{
//    Console.WriteLine($"{talaba1Ismi}ning balansi 60 mingdan kichik yoki teng");
//}


using N12_T1;

// Obyekt yaratish
Talaba talaba1 = new Talaba();

// Qiymat berish
talaba1.Ism = "Jasur";
talaba1.Yoshi = 23;
talaba1.Balansi = 50000.00;

//// Ishlatish
//Console.WriteLine(talaba1.Ism);     // Jasur
//Console.WriteLine(talaba1.Yoshi);   // 23
//Console.WriteLine(talaba1.Balansi); // 50000.00


Talaba talaba2 = new Talaba();
talaba2.Ism = "Oydinoy";
talaba2.Yoshi = 17;
talaba2.Balansi = 50_000.00;

Talaba talaba3 = new Talaba();
talaba3.Ism = "Alijon";
talaba3.Yoshi = 16;
talaba3.Balansi = 60_000.00;

Talaba talaba4 = new Talaba();
talaba4.Ism = "Iqbol";
talaba4.Yoshi = 16;
talaba4.Balansi = 70_000.00;

// Har birini ismlarini chiqarib    
//Console.WriteLine(talaba2.Ism);
//Console.WriteLine(talaba3.Ism);
//Console.WriteLine(talaba4.Ism);

talaba2.MalumotChopEt();
//talaba3.MalumotChopEt();
//talaba4.MalumotChopEt();

Console.WriteLine("\n");

talaba2.TolovQilish(10_000.00);
Console.WriteLine("\n");

// Metod va funksiya farqi, aslida ular bitta narsa, lekin metodlar obyektga tegishli bo'ladi, funksiya esa umumiy bo'ladi.



