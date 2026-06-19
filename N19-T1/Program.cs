// O'tgan dars biz - Collecsiyalarni o'tgan edik
// Amaliyot

//Quyidagi kolleksiya tiplarini ishlatish zarur bo'lgan 3 ta hayotiy misollar keltiring

//- List
//- Stack
//- Queue
//- Dictionary

// Listga hayotiy 3 ta misol:
// 1. O'nline do'kondagi savatchadagi mahsulotlar ro'yhati
// 2. Talabalar jurnali
// 3. Tranzzaksiya tarixi

List<string> shoppingCard = new List<string>() { "Noutbuk", "Sichqoncha", "Klaviatura" };

// Queue ga 3 ta misol: FIFO
// 1. Bankdagi navbat
// 2. Printerni chop etish jarayoni
// 3. Call centerdagi qo'ng'iroqlar jarayoni

Queue<string> queue = new Queue<string>();
queue.Enqueue("Hisobot");
queue.Enqueue("Shartnoma");
queue.Enqueue("Guvohnoma");

// Stack ga hayotiy 3 ta misol: LIFO
// 1. Idishdagi chips
// 2. Tarelkalar tahlash va ishlatish jarayoni
// 3. FileExploler dagi back belgisi ishlashi

Stack<string> undoHistory = new Stack<string>();
undoHistory.Push("Matn yozildi");
undoHistory.Push("Rasm qoyildi");
string lastAction = undoHistory.Pop();
Console.WriteLine(lastAction);

// Dictionary ga 3 ta misol hayotiy
// 1. Telefondagi kontakt
// 2. Mahsulotlar va - narxi
// 3. Google acaunt va uni paroli

Dictionary<string, double> productPrices
    = new Dictionary<string, double>()
    {
        {"Flesh", 10000 },
        {"Flavis", 8000 },
        {"Fuse Tea", 8000 }
    };
