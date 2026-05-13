
//// Tagida kiritishimizni kutadi
//Console.WriteLine("Ismizni kiriting: ");
//string name1 = Console.ReadLine();


//// y\Yonida ki``ritishimizni kutad  
//Console.Write("Malumot yozing:  ");
//int name2 = Console.Read();
//Console.WriteLine(name2);


//// Switch case misoli
//Console.Write("Hafta kunini kiriting: ");
//int day = int.Parse(Console.ReadLine());

//switch (day)
//{
//    case 1: Console.WriteLine("Dushanba"); break;
//    case 2: Console.WriteLine("Seshanba"); break;
//    case 3: Console.WriteLine("Chorshanba"); break;
//    case 4: Console.WriteLine("Payshanba"); break;
//    case 5: Console.WriteLine("Juma"); break;
//    case 6: Console.WriteLine("Shanba"); break;
//    case 7: Console.WriteLine("Yakshanba"); break;
//    default: Console.WriteLine("Bugun ahvollar joyidami og’ayni???"); break;
//}

//// Math sinfini ko'rib chiqamiz
//// +, -, *, /, %
//// Math.Sin(), Math.Cos(), Math.Tan(), Math.Sqrt(), Math.Pow(),
//// Math.Abs(), Math.Round(), Math.Ceiling(), Math.Floor() va boshqalar.

//// Math.Abs() - bu metod berilgan sonning musbat qiymatini qaytaradi
//int a = -22;
//Console.WriteLine(Math.Abs(a));


//// Math.Sqrt() - bu metod berilgan sonning kvadrat ildizini qaytaradi
//int b = 16;
//Console.WriteLine(Math.Sqrt(b));

//// Math.Pow() - bu metod berilgan sonning darajasini qaytaradi
//int c = 2;
//Console.WriteLine(Math.Pow(b, c));

// Takrorlash operatorlari: for;

// for (Start; Stop; Step)

//for (int i = 1; i <= 100; i++)
//{
//    if (i >= 50 && i <= 60)
//    {
//        Console.WriteLine($"{i}. Sherbek");
//    }
//    else if (i >= 90 && i <= 100)
//    {
//        Console.WriteLine($"{i}. Ozodbek");
//    }
//    else
//    {
//        Console.WriteLine($"{i}. Oydinoy");
//    }
//}

//// Cheksiz sikl
//for ( ; ; )
//{
//    Console.WriteLine("I speak C#");
//}


//masala

Console.Write("Oy raqamini kiriting: ");
int moth = int.Parse(Console.ReadLine());

switch (moth)
{
    case 1: Console.WriteLine("Yanvar"); break;
    case 2: Console.WriteLine("Fevral"); break;

    default: Console.WriteLine("Bunday oy mavjud emas"); break;
}