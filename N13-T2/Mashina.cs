namespace N13_T2;

public class Mashina
{
    public string Rusumi;
    public string Rangi;
    public double YoqilgiLitr;

    public void MalumotChiqar()
    {
        Console.WriteLine($"Rusumi: {Rusumi}");
        Console.WriteLine($"Rangi: {Rangi}");
        Console.WriteLine($"Yoqilgi Litr: {YoqilgiLitr}");
    }

    public void YoqilgiQuyish(double litr)
    {
        YoqilgiLitr += litr;
        Console.WriteLine($"Yoqilgi quyildi: {litr} litr. Jami yoqilgi: {YoqilgiLitr} litr.");
    }
}
