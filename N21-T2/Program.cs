using N21_T2;

List<IUchuvchi> uchuvchilar = new List<IUchuvchi>
{
    new Parranda()
};

foreach (IUchuvchi u in uchuvchilar)
{
    u.Uch();
}
