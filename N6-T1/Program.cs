// Massiv yani Arraylar - bir hil typedagi bir qancha malumotlarni saqlovchi kanteyner.
// Arraylar indekslangan va o'lchami belgilangan ma'lumotlar tuzilmasidir.
// Ular bir hil typedagi elementlarni saqlaydi va indeks orqali ularga murojaat qilish imkonini beradi.

//int a = 5;
//int b = 6;
//int c = 7;
//int d = 8;

//// Array bu - collection
//// Arrayni elon qilish usullari
//// 1-usul
//int[] sonlar = new int[12];

//sonlar[0] = 23;
//sonlar[1] = 24;
//sonlar[2] = 25;
//Console.WriteLine(sonlar[1]);


// index tushunchasi - array elementlariga qoyilgan raqamlar. Index 0 dan boshlanadi.

// 2-usul
//char[] sonlar2 = new char[] { 'a', 'b', 'c', 'd', 'e' };

//sonlar2[0] = '?';
////Console.WriteLine(sonlar2[0]);

//// Length - arrayning uzunligini qaytaradi
////Console.WriteLine(sonlar2.Length);

//for (int i = 0; i < sonlar2.Length; i++)
//{
//    Console.WriteLine(sonlar2[i]);
//}
//Console.WriteLine("\n");
//// Foreach boyicha ishlatish

//foreach (char item in sonlar2)
//{
//    Console.WriteLine(item);
//}

//// 3-usul

//string[] ismlar = { "Sherbek", "Alijon", "Ozodbek", "Oydinoy", "Jasur" };

//double[] baholar = { 3.44, 4, 2, 5, 0.9 };

//foreach (var ism in ismlar)
//{
//    if (ism == "Jasur")
//    {
//        Console.WriteLine("Jasur ismi topildi!");
//    }
//}

//Console.WriteLine("\n");

//for (int i = 0; i < baholar.Length; i++)
//{
//    if (baholar[i] >= 4)
//    {
//        Console.WriteLine($"Talaba {ismlar[i]} yaxshi bahoga ega!");
//    }
//}

// Bizga butun sonlardan iborat 20 ta elementi bor massiv beriladi. Ular ichidan juft sonlarni ekranga chiqaramiz
// va ularni indexini ham chiqaramiz!

//int[] sonlar3 = new int[20];
//for (int i = 0; i < sonlar3.Length; i++)
//{
//    Console.Write($"{i} indexdagi sonni kiriting: ");
//    sonlar3[i] = int.Parse(Console.ReadLine());
//}

//// Faqat juftlarini ajratib olish.
////int[] juftSonlar = new int[20];

//Console.Write("Ichidagi juft sonlar :  ");
//foreach (int i in sonlar3)
//{
//    if (i % 2 == 0)
//    {
//        Console.Write($"{i} ");
//    }
//}

//// Masala 2
//int[] sonlar = new int[10];
//for (int i = 0; i < sonlar.Length; i++)
//{
//    Console.Write($"{i + 1} elementini kiriting: ");
//    sonlar[i] = int.Parse(Console.ReadLine());
//}

//int max = sonlar[0], min = sonlar[0];
//int S = 0;

//for (int i = 0; i < sonlar.Length; i++)
//{
//    if (sonlar[i] > max)
//    {
//        max = sonlar[i];
//    }
//    if (sonlar[i] < min)
//    {
//        min = sonlar[i];
//    }
//    S += sonlar[i];
//}

//Console.WriteLine($"Eng katta son: {max}");
//Console.WriteLine($"Eng kichik son: {min}");
//Console.WriteLine($"Barcha sonlar yig'indisi: {S}");
//Console.WriteLine("\n");


// Masala 3

int[] haroratlar = { 22, 25, 19, 28, 24, 21, 26 };
string[] kunlar = { "Dushanba", "Seshanba", "Chorshanba", "Payshanba", "Juma", "Shanba", "Yakshanba" };


int son1 = haroratlar.Max(); // Max() - massivdagi eng katta elementni qaytaradi
int son2 = haroratlar.Min();   // Min() - massivdagi eng kichik elementni qaytaradi
double urta = haroratlar.Average(); // Average() - massivdagi elementlarning o'rtacha qiymatini qaytaradi
// maximal harorat bolgan kunni topish
// minimal harorat bolgan kunni topish
// o'rtacha haroratni hisoblash

for (int i = 0; i < haroratlar.Length; i++)
{
    if (haroratlar[i] == haroratlar.Max())
    {
        Console.WriteLine($"Eng yuqori harorat {haroratlar[i]} bo'lib, {kunlar[i]} kunida kuzatilgan.");
    }
    if (haroratlar[i] == haroratlar.Min())
    {
        Console.WriteLine($"Eng past harorat {haroratlar[i]} bo'lib, {kunlar[i]} kunida kuzatilgan.");
    }
}
Console.WriteLine($"O'rtacha harorat: {urta:F2}");










