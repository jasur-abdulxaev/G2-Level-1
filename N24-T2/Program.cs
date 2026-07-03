// Try- catch  - xatolarni ushlash
// Compile time xatolik 
// Runtime xatoli farqi 
/*
try
{
    int a = 10;
    int b = 0;
    int result = a / b; // Bu yerda runtime xatolik yuz beradi (DivideByZeroException)
    Console.WriteLine(result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Xatolik yuz berdi: {ex.Message}");
}
finally
{
    Console.WriteLine("Bu blok har doim ishlaydi.");
}
*/

// Try - xatolik yuz berishi mumkun bo'lgan kodni ushlash uchun ishlatiladi.
// Catch - Xatolik ushlanadi
// Finally - har doim ishlaydi, xatolik bo'lsa ham, bo'lmasa ham


try
{
    string input = "abc";
    int number = int.Parse(input); // Bu yerda runtime xatolik yuz beradi (FormatException)
}
catch (FormatException ex)
{
    Console.WriteLine("Noto'g'ri formatda ma'lumot kiritildi." + ex.Message);
}
catch (OverflowException ex)
{
    Console.WriteLine("Son qiymati chegaradan tashqari." + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Kutulmagan xatolik yuz berdi." + ex.Message);
}

// DivideByZeroException - 0 ga bo'lish xatoligi
// NullReferenceException - null qiymatga murojaat qilish xatoligi
// FormatException - noto'g'ri formatdagi ma'lumotни o'qishga urinish xatoligi
// OverflowException - son qiymati chegaradan tashqari bo'lish xatoligi
// IndexOutOfRangeException - massiv yoki ro'yxat chegarasidan tashqariga chiqish xatoligi
// InvalidOperationException - noto'g'ri operatsiya bajarishga urinish xatoligi


