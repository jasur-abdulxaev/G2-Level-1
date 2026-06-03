
using ItLiveKurs;

Kurs dotnet = new Kurs();
dotnet.Nomi = "Backend .NET Kursi";
dotnet.Narxi = 590_000.00;
dotnet.DavomiylikKunlari = 90;
dotnet.UstozIsmi = "Jasurbek aka";
dotnet.OquvchilarSoni = 5;

Kurs frontend = new Kurs();
frontend.Nomi = "Frontend React Kursi";
frontend.Narxi = 4_090_000.00;
frontend.DavomiylikKunlari = 60;
frontend.UstozIsmi = "Shoxrux aka";
frontend.OquvchilarSoni = 10;

Console.WriteLine("=== IT Live Kurslar ===");
dotnet.MalumotChiqar();
Console.WriteLine();
frontend.MalumotChiqar();
Console.WriteLine("\n");

Console.WriteLine("\n=== Kurs Narxi Darajasi ===");
Console.WriteLine($"DotNet kursi: {dotnet.NarxDarajasi()}");
Console.WriteLine($"Frontend kursi: {frontend.NarxDarajasi()}");
Console.WriteLine();

Console.WriteLine("=== O'zgarishlar ===");
dotnet.OquvchilarSoni = 7;
frontend.OquvchilarSoni = 12;

dotnet.MalumotChiqar();
Console.WriteLine();
frontend.MalumotChiqar();
Console.WriteLine();

frontend.ChegirmaQollash(20);
dotnet.OquvchiQoshish(5);

Console.WriteLine("=== Yangilangan Malumotlar ===");
dotnet.MalumotChiqar();
frontend.MalumotChiqar();



