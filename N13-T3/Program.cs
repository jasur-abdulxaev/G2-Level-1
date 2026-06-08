using N13_T3;

// Obyekt olish
Futbolchi futbolchi1 = new Futbolchi();
futbolchi1.Ism = "Lionel Messi";
futbolchi1.Jamoa = "Paris Saint-Germain";
//futbolchi1.GollarSoni = 10;


futbolchi1.MalumotChiqar();
futbolchi1.GolUrish(5);
Console.WriteLine($"Daraja: {futbolchi1.DarajaAniqla()}");
