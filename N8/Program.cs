// String va String builder

//// string - reference type, immutable (o'zgarmas) type

//string name = "Sherbek";
//string modifiedName = name.Replace("Sherbek", "Ozodbek");

//// Xotirada nima no'ldi? 
//Console.WriteLine(name);        // "Sherbek"
//Console.WriteLine(modifiedName); // "Ozodbek"


//// String concatenation muammosi?
//string result = "What is Lorem Ipsum?\r\nLorem Ipsum is simply dummy text of the printing and typesetting industry." +
//    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an " +
//    "unknown printer took a galley of type and scrambled it to make a type specimen book. " +
//    "It has survived not only five centuries, but also the leap into electronic typesetting," +
//    " remaining essentially unchanged. It was popularised in the 1960s with the release of " +
//    "Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including " +
//    "versions of Lorem Ipsum.\r\n\r\nWhy do we use It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).it?\r\nIt is a long established fact that a reader will be distracted by the readable" +
//    " content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of " +
//    "letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing" +
//    " packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover " +
//    "many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose " +
//    "(injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.";

//for (int i = 0; i < 1_000_000; i++)
//{
//    result += " Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
//        " Lorem Ipsum has been the industry's standard dumIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).my text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";
//}

//Console.WriteLine(result);

// Nima muammo? - Dastur sekinlashdi, Xotiradan joy juda katta oladi, Xotira sızıntısı (memory leak) yuzaga kelishi mumkin

// muammoni hal qilish uchun StringBuilder dan foydalanamiz
// StringBuilder - mutable (o'zgarmas) type, string manipulyatsiyalar uchun optimallashtirilgan class
using System.Text;

//string name1 = "Iqbol";
//name1 = name1.ToLower(); // iqbol - string immutable bo'lgani uchun name1 o'zgaruvchisiga yangi string qiymat tayinlandi

//StringBuilder name2 = new StringBuilder();
//name2.Append("Iqbol"); // StringBuilder mutable bo'lgani uchun name2 o'zgaruvchisiga yangi string qiymat tayinlanmaydi,
//                       // mavjud string o'zgartiriladi

//StringBuilder result = new StringBuilder();
//result.Append("What is Lorem Ipsum?\r\nLorem Ipsum is simply dummy text of the printing and typesetting industry." +
//    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an " +
//    "unknown printer took a galley of type and scrambled it to make a type specimen book. " +
//    "It has survived not only five centuries, but also the leap into electronic typesetting," +
//    " remaining essentially unchanged. It was popularised in the 1960s with the release of " +
//    "Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including " +
//    "versions of Lorem Ipsum.\r\n\r\nWhy do we use It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).it?\r\nIt is a long established fact that a reader will be distracted by the readable" +
//    " content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of " +
//    "letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing" +
//    " packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover " +
//    "many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose " +
//    "(injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from" +
//    " the 1914 translation by H. Rackham.");

//for (int i = 0; i < 1_000_000; i++)
//{
//    result.Append(" Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
//        " Lorem Ipsum has been the industry's standard dumIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).my text ever since the 1500s, when an unknown printer took a galley of type and" +
//        " scrambled it to make a type specimen book.");
//}

//Console.WriteLine(result);

// StringBuilder bilan ishlashda, oxirida ToString() methodini chaqirib, natijaviy string qiymatni olish kerak
// Qachon string va qachon stringbuilder ishlatamiz?
// Agar matn manipulyatsiyalar kam bo'lsa yoki umuman bo'lmasa, string ishlatish ma'qul
// Agar matn manipulyatsiyalar ko'p bo'lsa, StringBuilder ishlatish ma'qul

string name = "Sherbek";
string description = "U juda ko'p dars qiladi!";
int age = 16;

Console.WriteLine($"Name: {name}, Description: {description}, Age: {age}");
Console.WriteLine("\n");

var strbuilder = new StringBuilder();
strbuilder.Append("Name: ").Append(name).Append(", Description: ").Append(description).Append(", Age: ").Append(age);
Console.WriteLine(strbuilder.ToString());

