// while operatori takrorlashi uchun ishlatiladi. Quyidagi misolda, foydalanuvchi 0 kiritmaguncha sonlarni yig'ib boradigan dastur yozilgan:


//while (true)
//{
//    Console.Write("Son kiriting: ");
//    int number = int.Parse(Console.ReadLine());

//    if (number == 0)
//    {
//        Console.WriteLine("Dastur to'xtatildi.");
//        break; // while loopni to'xtatish
//    }
//}

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Salom Sherbek");
//}
//Console.WriteLine();

//int sikl = 0;
//while (sikl < 5)
//{
//    Console.WriteLine($"Salom Ozodbek");
//    sikl = sikl + 1;
//}
//Console.WriteLine();

//// Takrorlash operatorlari: do-while;

//int k = 0;
//do
//{
//    Console.WriteLine($"Salom Oydinoy");
//    k = k + 1;
//} while (k < 5);

//Console.WriteLine();



// 1-masala

//int S = 0;
//Console.Write("Son kiriting: ");
//int n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    S += i;
//}

//Console.WriteLine($"1 dan {n} gacha sonlar yig'indisi {S} ga teng.");

//// 2-masala
//int P = 0;
//Console.WriteLine("Son kiriting: ");
//int m = int.Parse(Console.ReadLine());

//for (int i = 1; i <= m; i++)
//{
//    if (i % 2 == 0)
//    {
//        P += i;
//    }
//}
//Console.WriteLine($"{m} gacha juft sonlar yig'indisi {P} ga teng.");

// 3 masala
// n sonini raqamlari yig';indisini hisoblovchi dastur whileda

//int S = 0;

//Console.Write("Son kiriting: ");
//int n = int.Parse(Console.ReadLine());

//while (n > 0)
//{
//    int oxirgiRaqam = n % 10; // Sonning oxirgi raqamini olish
//    //Console.Write($"Oxirgi raqam: {oxirgiRaqam}");
//    S += oxirgiRaqam;
//    //Console.WriteLine($"\nYigindi: {S}");
//    n = n / 10; // Sonning oxirgi raqamini olib tashlash
//}

//Console.WriteLine($"Barcha raqamlar yig'indisi: {S}");

// 4-masala Parol kiritilmaguncha qayta qayta so'rash do whilega o'xshash bo'ladi

//string parol = "12345";

//do
//{
//    Console.Write("Parolni kiriting: ");
//    parol = Console.ReadLine();
//    if (parol != "12345")
//    {
//        Console.WriteLine("Parol noto'g'ri, qayta urinib ko'ring.");
//    }
//} while (parol != "12345");

//Console.WriteLine("Parol to'g'ri kiritildi.");


// Break va Continue, return operatorlari

//qayt:
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        Console.WriteLine("Bu raqam 5 ga teng, sikl o'tkazvordi.");
        //break; // for loopni to'xtatish
        //continue; // for loopni davom ettirish, lekin 5 ni o'tkazib yuborish
        //goto qayt;
    }
    Console.WriteLine(i);
}

Console.WriteLine();

// Break - bu operator siklni to'xtatish uchun ishlatiladi.
// Agar break operatori ishlatilsa, sikl darhol to'xtaydi va siklning tashqarisidagi kod bajariladi.

// Continue - bu operator siklni davom ettirish uchun ishlatiladi,
// lekin siklning joriy iteratsiyasini o'tkazib yuboradi.

// goto - bu operator kodning boshqa qismiga o'tish uchun ishlatiladi.