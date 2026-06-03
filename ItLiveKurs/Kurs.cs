namespace ItLiveKurs;

public class Kurs
{
    // fieldlar - bu yerda kurs haqida ma'lumotlar saqlanadi
    public string Nomi;
    public double Narxi;
    public string UstozIsmi;
    public int OquvchilarSoni;
    public int DavomiylikKunlari;

    // metodlar - bu yerda kurs bilan bog'liq amallar bajariladi
    // 1 - method - malumot chiqarish.
    public void MalumotChiqar()
    {
        Console.WriteLine($"Kurs nomi: {Nomi}");
        Console.WriteLine($"Kurs narxi: {Narxi}");
        Console.WriteLine($"Ustoz ismi: {UstozIsmi}");
        Console.WriteLine($"O'quvchilar soni: {OquvchilarSoni}");
        Console.WriteLine($"Davomiylik kunlari: {DavomiylikKunlari}");
    }

    // 2 - method - yangi o'quvchi qo'shish
    public void OquvchiQoshish(int soni)
    {
        OquvchilarSoni += soni;
        Console.WriteLine($"{soni} ta o'quvchi qo'shildi. Jami o'quvchilar soni: {OquvchilarSoni}");
    }

    // 3 - method - chegirma qilish
    public void ChegirmaQollash(int foiz)
    {
        double chegirmaMiqdori = Narxi * foiz / 100;
        double yangiNarx = Narxi - chegirmaMiqdori;
        Console.WriteLine($"{foiz}% chegirma qo'llandi. Yangi narx: {yangiNarx}");
    }

    // 4 - method - kurs qimmatmi darajasi
    public string NarxDarajasi()
    {
        if (Narxi >= 1_000_000) return "Qimmat";
        else if (Narxi >= 500_000) return "O'rtacha";
        else return "Arzon";
    }



}
