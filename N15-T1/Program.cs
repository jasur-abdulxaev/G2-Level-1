using N15_T1;

Talaba talaba1 = new Talaba("Sherbek", 16, 85_000);

Talaba talaba2 = new Talaba("Iqbol", 17, 90_000);

// O'qish
Console.WriteLine(talaba2.Ism);     // Iqbol
Console.WriteLine(talaba2.Balansi); // 90000

// Yozish
talaba2.Ism = "Iqbolbek";
// talaba2.Balansi = 95_000;   // Error: Balansi property set blokiga ega emas, shuning uchun unga qiymat berib bo'lmaydi
Console.WriteLine(talaba2.Ism);     // Iqbolbek
Console.WriteLine(talaba2.Balansi); // 95000






