
#region Boshlanish
// Async - Await - - BUGUNGI MAVZU
/*
1) async - metodni  "bu metod asinxron ishlaydi" deb belgilaydi. 
Asinxron metodlar odatda uzoq davom etadigan operatsiyalarni bajarish uchun ishlatiladi, masalan, fayl yuklash, ma'lumotlarni olish yoki tarmoq so'rovlarini bajarish. Asinxron metodlar bajarilayotganda, ular boshqa kodni bloklamasdan ishlashga imkon beradi.
2) await - "bu ish tugashini kut, lekin dasturni bloklama" degani.
3) Task - "kelajakda tugaydigan ish" degan manoni anglatadi. Task obyektlari asinxron operatsiyalarni ifodalaydi va ular bajarilganda natijani olish imkonini beradi.
 */
// Async method nomi odatda Async bilan tugaydi. Masalan, DownloadFileAsync(), GetDataAsync()
// Async method Task yoki Task<T> turini qaytaradi. (VOID emas)
//await faqat async metod ichida ishlatilinadi
// Task.Delay() - Thread.Sleep() ning asinxron versiyasi. Bu metod berilgan vaqt davomida kutadi, lekin dasturni bloklamaydi.

/*
Console.WriteLine("Dastur boshlandi!");

await DownloadFile();

Console.WriteLine("Dastur tugadi!");


static async Task DownloadFile()
{
    Console.WriteLine("Fayl yuklanmoqda...");
    await Task.Delay(3000);
    Console.WriteLine("Fayl yuklandi!");
}
*/
#endregion

//Natija qaytaruvchi async method
int result = await CalculateSquareAsync(6);
Console.WriteLine($"6 ning kvadrati: {result}");

static async Task<int> CalculateSquareAsync(int number)
{
    Console.WriteLine("Hisoblanmoqda...");
    await Task.Delay(2000); // 2 soniya kutish
    return number * number;
}



