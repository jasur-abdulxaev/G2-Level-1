namespace N15_T1;

public class Talaba
{
    // private - faqat class ichidan ko'rinadi, tashqaridan kira olmaydi
    private string _Ism;
    private int _Yoshi;
    private double _Balansi;

    public Talaba(string ism, int yoshi, double balansi)
    {
        this._Ism = ism;
        this._Yoshi = yoshi;
        this._Balansi = balansi;
    }

    // Property - private fieldga tashqaridan kira olish uchun ishlatiladi
    public string Ism
    {
        get
        {
            return _Ism;    // get - qiymatni olish uchun ishlatiladi, o'qish
        }
        set
        {
            _Ism = value;   // Yozish uchun ishlatiladi, value - propertyga berilgan yangi qiymat
        }
    }

    public double Balansi
    {
        get
        {
            return _Balansi;
        }
        //set
        //{
        //    _Balansi = value;
        //}
    }

    // value nima? -> value - kalit so'z bo'lib, propertyga berilgan yangi qiymatni ifodalaydi.
    // Misol uchun, talaba1.Ism = "Ali"; bu yerda "Ali" value ga teng bo'ladi va set blokida _Ism fieldiga "Ali" qiymati beriladi.














}
