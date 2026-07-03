// LINQ - Language Integrated Query bu C# tilida kollektsiyalar bilan ishlash uchun qulay sintaksis va metodlarni taqdim etadi. LINQ yordamida siz massivlar, ro'yxatlar, ma'lumotlar bazalari va boshqa kollektsiyalar bilan ishlashni osonlashtirishingiz mumkin.

/* // Where()
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Toqlarini tanlab olish
var oddNumbers = numbers.Where(x => x % 2 == 1);

foreach (var number in oddNumbers)
{
    Console.Write(number + " ");
}
*/

/* // Select() metodi
List<string> names = new List<string>
{
    "Sherbek",
    "Alijon",
    "Oydinoy",
    "Iqbol",
    "Jasur"
};

var upperNames = names.Select(name => name.ToUpper());

foreach (var upperName in upperNames)
{
    Console.WriteLine(upperName);
}
*/

/*// OrderBy() metodi
List<int> numbers = new List<int> { 5, 2, 8, 1, 4, 9, 3, 7, 6, 10 };

var sortedNumbers = numbers.OrderBy(x => x).ToList();

foreach (var number in sortedNumbers)
{
    Console.Write(number + " ");
}
*/

/*// OrderByDescending() metodi
List<int> numbers = new List<int> { 5, 2, 8, 1, 4, 9, 3, 7, 6, 10 };

var sortedNumbers = numbers.OrderByDescending(n => n).ToList();

foreach (var number in sortedNumbers)
{
    Console.Write(number + " ");
}
*/

/*// First() metodi
List<int> numbers = new List<int> { 5, 2, 8, 1, 4, 9, 3, 7, 6, 10 };

int firstNumber = numbers.First();  // 5
int secondNumber = numbers.Last();  // 10
int firstOrDefaultNumber = numbers.FirstOrDefault();  // hech nima bolmasa xato bermaydi

Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);
Console.WriteLine(firstOrDefaultNumber);
*/

/*// Count() metodi
List<int> numbers = new List<int> { 5, 2, 8, 1, 4, 9, 3, 7, 6, 10 };

Console.WriteLine(numbers.Count()); // 10
*/




