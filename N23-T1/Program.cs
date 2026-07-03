// Generics - nima uchun kerak
// Generics har hil typelar uchun kodni takrorlamasdan yozadigan umumiy class yoki methodlarni yaratish imkonini beradi. Bu kodni qayta ishlatish va turli typelar bilan ishlashni osonlashtiradi. Generics yordamida siz bir xil algoritmni turli typelar bilan ishlatishingiz mumkin, bu esa kodni yanada samarali va o'qilishi oson qiladi.

using N23_T1;

var intBox = new Box<int>(42);
var stringBox = new Box<string>("Hello, Generics!");

intBox.Show(); // Output: Value: 42, Type: Int32)
stringBox.Show(); // Output: Value: Hello, Generics!, Type: String)

