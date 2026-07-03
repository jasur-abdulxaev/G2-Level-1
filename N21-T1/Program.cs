using N21_T1;

// abstract class - to'liq bo'lmagan klass

List<Shakl> shakllar = new List<Shakl>()
{
    new Doira("Doira", 5),
    new Tortburchak("Tortburchak", 4, 6)
};

foreach (var s in shakllar)
{
    s.Malumot();    // Polimorfizm + abstract class birgalikda ishlayabdi
}





