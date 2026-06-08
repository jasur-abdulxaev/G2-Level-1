using N14_T1;

Talaba talaba1 = new Talaba("Sherbek", 16, 50_000);
talaba1.MalumotChiqar();

Talaba talaba2 = new Talaba("Jasur", 23, 45_000);
talaba2.MalumotChiqar();

Talaba talaba3 = new Talaba("Oydinoy", 17, 500_000);
talaba3.MalumotChiqar();

Talaba talaba4 = new Talaba("Sug'diyona", 20, 100_000);
talaba4.MalumotChiqar();
Console.WriteLine("\n");

Talaba talaba5 = new Talaba("Bonu", 18, 41_000); // construktor 1 - barcha parametrlarni qabul qiladi
talaba5.MalumotChiqar();

Talaba talaba6 = new Talaba("Dilshod", 20); // construktor 2
talaba6.MalumotChiqar();

Talaba talaba7 = new Talaba("Gulnoza"); // construktor 3
talaba7.MalumotChiqar();

Talaba talaba8 = new Talaba("Sardor", 30_000); // construktor 4
talaba8.MalumotChiqar();

Mashina mashina1 = new Mashina("Chevrolet", "Malibu 2", 2024);
mashina1.MalumotChiqar();