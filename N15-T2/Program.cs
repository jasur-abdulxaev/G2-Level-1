using N15_T2;

Console.WriteLine("=== Kurs Malumotlari ===");

Kurs dotnet = new Kurs("C# va .NET", "Jasurbek", 590_000, 15, 3);
dotnet.MalumotChiqar();
dotnet.StatusAniqla();

Console.WriteLine("=== O'quvchi Qo'shish ===");
dotnet.OquvchiQoshish(5);
dotnet.OquvchiQoshish(50); // Xato: 50 ta oquvchi qo'shish mumkin emas. Maksimal oquvchilar soni 30 ta.
dotnet.MalumotChiqar();

//Console.WriteLine("=== Noto'g'ri Ma'lumotlar ===");
//dotnet.Nomi = ""; // Xato: Kurs nomi bo'sh bo'lishi mumkin emas.
//dotnet.UstozIsmi = ""; // Xato: Ustoz ismi bo'sh bo'lishi mumkin emas.
//dotnet.Narxi = -1000; // Xato: Kurs narxi manfiy bo'lishi mumkin emas.
//dotnet.OquvchilarSoni = -5; // Xato: Oquvchilar soni manfiy bo'lishi mumkin emas.
//dotnet.DavomiylikVaqti = -1; // Xato: Davomiylik vaqti manfiy bo'lishi mumkin emas.

