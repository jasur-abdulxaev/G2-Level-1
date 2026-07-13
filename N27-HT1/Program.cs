
string filePath = "D:\\Back End\\G2-Level-1\\N27-HT1\\talabalar.txt";
bool running = true;

while (true)
{
    Console.WriteLine("=== TALABALAR RO'YXATI === ");
    Console.WriteLine("1. Yangi talaba qo'shish");
    Console.WriteLine("2. Barcha talabalarni ko'rish");
    Console.WriteLine("3. Chiqish");
    Console.Write("Tanlovingiz: ");

    string? tanlov = Console.ReadLine();

    switch (tanlov)
    {
        case "1":
            Console.Write("Ismi: ");
            string ism = Console.ReadLine() ?? "";

            Console.Write("Yoshi: ");
            string yosh = Console.ReadLine() ?? "";

            Console.Write("Guruhi: ");
            string guruh = Console.ReadLine() ?? "";

            string qator = $"{ism}|{yosh}|{guruh}";
            File.AppendAllText(filePath, qator + Environment.NewLine);

            Console.WriteLine("Talaba qo'shildi!");
            break;

        case "2":
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Talabalar ro'yxati mavjud emas.");
                break;
            }

            string[] qatorlar = File.ReadAllLines(filePath);

            if (qatorlar.Length == 0)
            {
                Console.WriteLine("Ro'yhat hali bo'sh.");
                break;
            }

            Console.WriteLine("\n=== TALABALAR RO'YXATI ===");
            for (int i = 0; i < qatorlar.Length; i++)
            {
                string[] qismlar = qatorlar[i].Split('|');

                if (qismlar.Length < 3)
                    continue;

                string talabaIsmi = qismlar[0];
                string talabaYoshi = qismlar[1];
                string talabaGuruhi = qismlar[2];

                Console.WriteLine($"{i + 1}. Ismi: {talabaIsmi}, Yoshi: {talabaYoshi}, Guruhi: {talabaGuruhi}");
            }
            break;

        case "3":
            running = false;
            break;

        default:
            Console.WriteLine("Noto'g'ri tanlov. Iltimos, qayta urinib ko'ring.");
            break;
    }

    if (!running)
        break;
}

Console.WriteLine("Dasturdan chiqish amalga oshirildi. Dastur tugadi.");
