namespace N14_T2;

public class Kurs
{
    // fieldlari
    public string Nomi;
    public string UstozIsmi;
    public double Narxi;
    public int OquvchilarSoni;
    public int DavomiylikVaqti;


    // Construktor 1
    public Kurs(string nomi, string ustozIsmi, double narxi, int oquvchilarSoni, int davomiylikVaqti)
    {
        this.Nomi = nomi;
        this.UstozIsmi = ustozIsmi;
        this.Narxi = narxi;
        this.OquvchilarSoni = oquvchilarSoni;
        this.DavomiylikVaqti = davomiylikVaqti;
    }

    // Construktor 2
    public Kurs(string nomi, double narxi)
    {
        this.Nomi = nomi;
        this.UstozIsmi = "Noma'lum";
        this.Narxi = narxi;
        this.OquvchilarSoni = 0;
        this.DavomiylikVaqti = 0;
    }

    // Methodlar
    public void MalumotChiqar()
    {
        Console.WriteLine($"Kurs Nomi: {Nomi}, Ustoz Ismi: {UstozIsmi}, " +
            $"Narxi: {Narxi}, Oquvchilar Soni: {OquvchilarSoni}, Davomiylik Vaqti: {DavomiylikVaqti} oy");
    }

    public void OquvchiQoshish(int soni)
    {
        this.OquvchilarSoni += soni;
        Console.WriteLine($"{soni} ta oquvchi qo'shildi. Jami oquvchilar soni: {OquvchilarSoni}");
    }

    public void NarxOzgartirish(double yangiNarx)
    {
        this.Narxi = yangiNarx;
        Console.WriteLine($"Kurs narxi yangilandi. Yangi narx: {Narxi}");
    }

    public string StatusAniqla()
    {
        if (OquvchilarSoni >= 20) return "To'lgan guruh";
        else if (OquvchilarSoni >= 10) return "Yarim to'lgan guruh";
        else return "Kam sonli guruh";
    }
}
