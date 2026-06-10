namespace N15_T2;

class Kurs
{
    // private fieldlari
    private string _nomi;
    private string _ustozIsmi;
    private double _narxi;
    private int _oquvchilarSoni;
    private int _davomiylikVaqti;

    public Kurs(string nomi, string ustozIsmi, double narxi, int oquvchilarSoni, int davomiylikVaqti)
    {
        this._nomi = nomi;
        this._ustozIsmi = ustozIsmi;
        this._narxi = narxi;
        this._oquvchilarSoni = oquvchilarSoni;
        this._davomiylikVaqti = davomiylikVaqti;
    }

    public string Nomi
    {
        get { return _nomi; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Xato: Kurs nomi bo'sh bo'lishi mumkin emas.");
                return;
            }
            _nomi = value;
        }
    }

    public string UstozIsmi
    {
        get { return _ustozIsmi; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Xato: Ustoz ismi bo'sh bo'lishi mumkin emas.");
                return;
            }
            _ustozIsmi = value;
        }
    }

    double Narxi
    {
        get { return _narxi; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Xato: Kurs narxi manfiy bo'lishi mumkin emas.");
                return;
            }
            _narxi = value;
        }
    }

    public int OquvchilarSoni
    {
        get { return _oquvchilarSoni; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Xato: Oquvchilar soni manfiy bo'lishi mumkin emas.");
                return;
            }
            _oquvchilarSoni = value;
        }
    }

    public int DavomiylikVaqti
    {
        get { return _davomiylikVaqti; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Xato: Davomiylik vaqti manfiy bo'lishi mumkin emas.");
                return;
            }
            _davomiylikVaqti = value;
        }
    }


    public void MalumotChiqar()
    {
        Console.WriteLine($"Kurs Nomi: {Nomi}, Ustoz Ismi: {UstozIsmi}, " +
            $"Narxi: {Narxi}, Oquvchilar Soni: {OquvchilarSoni}, Davomiylik Vaqti: {DavomiylikVaqti} oy");
    }

    public void OquvchiQoshish(int soni)
    {
        int yangiSoni = OquvchilarSoni + soni;
        if (yangiSoni > 30)
        {
            Console.WriteLine($"Xato: {soni} ta oquvchi qo'shish mumkin emas. " +
                $"Maksimal oquvchilar soni 30 ta.");
        }
        else
        {
            this.OquvchilarSoni = yangiSoni;
            Console.WriteLine($"{soni} ta oquvchi qo'shildi. Jami oquvchilar soni: {OquvchilarSoni}");
        }
    }

    public void StatusAniqla()
    {
        if (OquvchilarSoni >= 20) Console.WriteLine("To'lgan guruh");
        else if (OquvchilarSoni >= 10) Console.WriteLine("Yarim to'lgan guruh");
        else Console.WriteLine("Kam sonli guruh");
    }




}
