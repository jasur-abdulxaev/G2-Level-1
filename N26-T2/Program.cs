
// Faylga yozish
string filePath = "D:\\Back End\\G2-Level-1\\N26-T2\\Kitoblar.txt";

// Faylga yangi qator qo'shamiz, eskisini o'chirmasdan
File.AppendAllText(filePath, "Kecha va Kunduz" + Environment.NewLine);

Console.WriteLine("yangi kitob qo'shildi!\n");

// Natijani ko'ramiz
string[] hammasi = File.ReadAllLines(filePath);
foreach (var qator in hammasi)
{
    Console.WriteLine("- " + qator);
}


