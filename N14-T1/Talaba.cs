namespace N14_T1;

public class Talaba
{
    // fieldlari
    public string Ism;
    public int Yoshi;
    public double Balansi;

    // Construktor - class nomi bilan bir hil boladi
    public Talaba(string Ism, int Yoshi, double Balansi)
    {
        this.Ism = Ism;
        this.Yoshi = Yoshi;
        this.Balansi = Balansi;
    }

    // Construktor overloading - bir nechta construktor yaratish
    public Talaba(string ism, int yoshi)
    {
        this.Ism = ism;
        this.Yoshi = yoshi;
        this.Balansi = 0; // default qiymat
    }

    // Construktor 3
    public Talaba(string ism)
    {
        this.Ism = ism;
        this.Yoshi = 0; // default qiymat
        this.Balansi = 0; // default qiymat
    }

    // construktor 4 
    public Talaba(string ism, double balansi)
    {
        this.Ism = ism;
        this.Yoshi = 0; // default qiymat
        this.Balansi = balansi;
    }
    public void MalumotChiqar()
    {
        Console.WriteLine($"Ism: {Ism}, Yoshi: {Yoshi}, Balansi: {Balansi}");
    }
}
