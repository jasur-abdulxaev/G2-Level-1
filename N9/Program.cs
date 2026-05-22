
// Funksiyalar 
// Void tipli funksiyalar, qiymat qaytarmaydigan funksiyalar, 

//void SalomBer()
//{
//    Console.WriteLine("Assalomu alaykum!");
//}

//SalomBer(); // Funksiyani chaqirish
//SalomBer(); // Funksiyani yana bir marta chaqirish
//SalomBer(); // Funksiyani yana bir marta chaqirish

// void - qiymat qaytarmaydigan funksiyalar uchun ishlatiladi.


//Parametrli funksiya(ma'lumot qabul qiluvchi)
void IsmiBilanSalomBer(string ism)
{

    Console.WriteLine($"Assalomu alaykum, {ism}!");
}

//IsmiBilanSalomBer("Sherbek"); // "Assalomu alaykum, Sherbek!" ni chiqaradi
//IsmiBilanSalomBer("Ozodbek"); // "Assalomu alaykum, Ozodbek!" ni chiqaradi
//IsmiBilanSalomBer("Oydinoy"); // "Assalomu alaykum, Oydinoy!" ni chiqaradi


//// Qiymat qaytaruvchi funksiya
//// 2 ta sonni qabul qilib, ularning yig'indisini qaytaruvchi funksiya
//int Yigindi(int x, int y)
//{
//    return x + y; // x va y ni qo'shib, natijani qaytaradi
//}
//// return - funksiyadan qiymat qaytarish uchun ishlatiladi. Yigindi funksiyasi x va y ni qo'shib, natijani qaytaradi.

//int natija1 = Yigindi(7, 12); // 7 va 12 ni qo'shib, natijani natija1 ga saqlaydi
//Console.WriteLine(natija1);

//int natija2 = Yigindi(15, 25); // 15 va 25 ni qo'shib, natijani natija2 ga saqlaydi
//Console.WriteLine(natija2);


//// haqiqiy kalkulyator funksiyasi
//double Calculator(double a, double b, char amal)
//{
//    switch (amal)
//    {
//        case '+':
//            return a + b;
//        case '-':
//            return a - b;
//        case '*':
//            return a * b;
//        case '/':
//            return a / b;
//        default:
//            Console.WriteLine("Noto'g'ri amal kiritildi");
//            return 0;
//    }
//}
//Console.WriteLine(Calculator(12, 87, '+'));


//// expression body - qisqa va oson yoziladigan funksiya tanasi
//double Qosh(double a, double b) => a + b; // Qosh funksiyasi a va b ni qo'shib, natijani qaytaradi
//double Ayir(double a, double b) => a - b; // Ayir funksiyasi a dan b ni ayirib, natijani qaytaradi
//double Kopaytir(double a, double b) => a * b; // Kopaytir funksiyasi a va b ni ko'paytirib, natijani qaytaradi
//double Bol(double a, double b) => a / b; // Bol funksiyasi a ni b ga bo'lib, natijani qaytaradi


//Console.WriteLine(Qosh(10, 10));
//Console.WriteLine(Ayir(10, 10));
//Console.WriteLine(Kopaytir(10, 10));
//Console.WriteLine(Bol(10, 10));


// Ko'p parametrli funksiya
void OquvchiniBaholash(string ism, int ball)
{
    if (ball >= 90)
    {
        Console.WriteLine($"A'lo natija, {ism}! Siz {ball} ball oldingiz.");
    }
    else if (ball >= 70)
    {
        Console.WriteLine($"Yaxshi natija, {ism}! Siz {ball} ball oldingiz.");
    }
    else if (ball >= 50)
    {
        Console.WriteLine($"Qoniqarli natija, {ism}! Siz {ball} ball oldingiz.");
    }
    else
    {
        Console.WriteLine($"Qoniqarsiz natija, {ism}! Siz {ball} ball oldingiz.");
    }
}

OquvchiniBaholash("Sherbek", 55); // "Qoniqarli natija, Sherbek! Siz 55 ball oldingiz."
OquvchiniBaholash("Ozodbek", 65); // "Qoniqarli natija, Ozodbek! Siz 65 ball oldingiz."
OquvchiniBaholash("Oydinoy", 80); // "Yaxshi natija, Oydinoy! Siz 80 ball oldingiz."
OquvchiniBaholash("Iqbolbek", 75); // "Yaxshi natija, Iqbolbek! Siz 75 ball oldingiz."
OquvchiniBaholash("Alijon", 45); // "Qoniqarsiz natija, Alijon! Siz 45 ball oldingiz."
OquvchiniBaholash("Jasur", 9); // "A'lo natija, Jasur! Siz 9 ball oldingiz."



// Xulosa
// Funksiyalar - kodni qayta ishlatish va tartibga solish uchun ishlatiladi.
// Void tipli funksiyalar qiymat qaytarmaydi, parametrli funksiyalar ma'lumot qabul qiladi, qiymat qaytaruvchi funksiyalar esa natija beradi.
// Parametrli funksiyalar yordamida kodni yanada moslashuvchan va qayta ishlatish mumkin bo'ladi. Expression body sintaksisi esa qisqa va oson yoziladigan funksiya tanasini yaratishga imkon beradi.
// expression body sintaksisi yordamida funksiya tanasini qisqa va oson yozish mumkin, bu kodni yanada o'qilishi va tushunilishi oson qiladi.





