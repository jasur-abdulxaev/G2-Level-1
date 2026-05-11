// 8 - task;
Console.Write("Oy raqamini kiriting: ");
int month = int.Parse(Console.ReadLine());

if (month == 12 || month == 1 || month == 2)
{
    Console.WriteLine("Qish");
}
else if (month == 3 || month == 4 || month == 5)
{
    Console.WriteLine("Bahor");
}
else if (month == 6 || month == 7 || month == 8)
{
    Console.WriteLine("Yoz");
}
else if (month == 9 || month == 10 || month == 11)
{
    Console.WriteLine("Kuz");
}
else
{
    Console.WriteLine("Noto'g'ri oy raqami kiritildi.");
}
