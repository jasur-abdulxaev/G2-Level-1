namespace N21_T1;

public abstract class Shakl
{
    public string Nomi { get; set; }

    public Shakl(string nomi)
    {
        Nomi = nomi;
    }

    // Abstract method - diqqat abstrakt metodda body yoq!
    public abstract double YuzaniHisobla();

    // Oddiy methodlari ham bor
    public void Malumot()
    {
        Console.WriteLine($"{Nomi}ning yuzasi: {YuzaniHisobla():F2}");
    }
}

public class Doira : Shakl
{
    public double Radiusi { get; set; }

    public Doira(string nomi, double radiusi) : base(nomi)
    {
        Radiusi = radiusi;
    }

    public override double YuzaniHisobla()
    {
        return Math.PI * Radiusi * Radiusi;
    }
}

public class Tortburchak : Shakl
{
    public double Eni { get; set; }
    public double Boyi { get; set; }

    public Tortburchak(string nomi, double eni, double boyi) : base(nomi)
    {
        Eni = eni;
        Boyi = boyi;
    }

    public override double YuzaniHisobla()
    {
        return Eni * Boyi;
    }
}
