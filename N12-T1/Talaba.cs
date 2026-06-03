namespace N12_T1;


// Class bu talaba haqida ma'lumotlarni saqlash uchun ishlatiladigan (QOLIP)
public class Talaba
{
    // Bu yerda "field"lar saqlanadi - bular obyekt malumotlari
    public string Ism;
    public int Yoshi;
    public double Balansi;

    public void MalumotChopEt()
    {
        Console.WriteLine($"Ism: {Ism}");
        Console.WriteLine($"Yoshi: {Yoshi}");
        Console.WriteLine($"Balansi: {Balansi}");
    }

    // Parametrli metod
    public void TolovQilish(double miqdor)
    {
        if (miqdor > Balansi)
        {
            Console.WriteLine($"{Ism}ning balansida yetarli mablag' yo'q");
        }
        else
        {
            Balansi -= miqdor;
            Console.WriteLine($"{Ism} {miqdor} so'm to'lov qildi. Yangi balans: {Balansi}");
        }
    }
}
