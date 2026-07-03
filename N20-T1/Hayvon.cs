namespace N20_T1;

public class Hayvon
{
    public string Ism { get; set; }

    public Hayvon(string ism)
    {
        Ism = ism;
    }

    public virtual void OvozChiqar()
    {
        Console.WriteLine($"{Ism} qandaydur ovoz chiqardi. ");
    }
}

public class It : Hayvon
{
    public It(string ism) : base(ism) { }

    // Diqqat bu yrda new qilinmayabdi! - Shunchaki qayta yozilyabdi.
    public override void OvozChiqar()
    {
        Console.WriteLine($"{Ism}: Vov-vov. ");
    }
}

public class Mushuk : Hayvon
{
    public Mushuk(string ism) : base(ism) { }

    public override void OvozChiqar()
    {
        Console.WriteLine($"{Ism} Miyov!");
    }
}
