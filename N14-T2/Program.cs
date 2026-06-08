using N14_T2;

Console.WriteLine("=== Kurs Malumotlari ===");

Kurs dotnet = new Kurs("Backend .NET", "Jasurbek ustoz", 600_000, 12, 90);

Kurs foundation = new Kurs("Frontend Foundation", 400_000);

Console.WriteLine("=== Boshlang'ich holat ===");
dotnet.MalumotChiqar();
Console.WriteLine($"Status: {dotnet.StatusAniqla()}");

foundation.MalumotChiqar();
Console.WriteLine($"Status: {foundation.StatusAniqla()}");

Console.WriteLine("=== O'zgartirishlar ===");
dotnet.OquvchiQoshish(8);
foundation.OquvchiQoshish(10);
foundation.NarxOzgartirish(450_000);

Console.WriteLine("=== O'zgartirilgan holat ===");
dotnet.MalumotChiqar();
Console.WriteLine($"Status: {dotnet.StatusAniqla()}");

foundation.MalumotChiqar();
Console.WriteLine($"Status: {foundation.StatusAniqla()}");
