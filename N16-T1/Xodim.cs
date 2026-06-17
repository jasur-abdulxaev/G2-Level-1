namespace N16_T1;

// Vorislik haqida
// base class - Ota class
public class Xodim
{
    public string Ismi { get; set; }

    public int Yoshi { get; set; }

    public double Oyligi { get; set; }

    public void MalumotKorsat()
    {
        Console.WriteLine($"Ismi: {Ismi}, Yoshi: {Yoshi}, Maoshi: {Oyligi}");
    }
}

class Dasturchi : Xodim
{
    public string DasturlashTili { get; set; }

    public void IshniKorsat()
    {
        Console.WriteLine($"{Ismi} - {DasturlashTili} dasturchisi!");
    }
}

class Dizayner : Xodim
{
    public string DizaynDasturi { get; set; }

    public void DasturniKorsat()
    {
        Console.WriteLine($"{Ismi} {DizaynDasturi} dasturda ishlaydi!");
    }
}

class Menejer : Xodim
{
    public int JamoadagiXodimlar { get; set; }

    public void JamoaniKorsat()
    {
        Console.WriteLine($"{Ismi} menejer, {JamoadagiXodimlar} ta odamga qaraydi!");
    }
}