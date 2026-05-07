// LINQ - Language Integrated Query, is a powerful feature in C# that allows developers to query and manipulate data in a more intuitive and readable way. It provides a consistent syntax for querying various data sources, such as collections, databases, XML, and more. LINQ enables developers to write queries directly in C#, making it easier to work with data and improving code readability.

using LinqR1;

List<Student> students =
[
    new Student {Id = 1, Name = "Shahriyor", Age = 15, Score = 85.5, Group = "R1" },
    new Student {Id = 2, Name = "Asilbek", Age = 14, Score = 90.0, Group = "R1" },
    new Student {Id = 3, Name = "Uchqunbek", Age = 17, Score = 88.0, Group = "R2" },
    new Student {Id = 4, Name = "Behruz", Age = 14, Score = 92.5, Group = "R1" },
    new Student {Id = 5, Name = "Behruz", Age = 16, Score = 80.0, Group = "R2" },
    new Student {Id = 6, Name = "Behruz", Age = 20, Score = 85.5, Group = "R1" },
    new Student {Id = 7, Name = "Dilnoza", Age = 17, Score = 90.0, Group = "R2" },
    new Student {Id = 8, Name = "John", Age = 15, Score = 85.5, Group = "R1" },
    new Student {Id = 9, Name = "Doe", Age = 14, Score = 90.0, Group = "R1" },
    new Student {Id = 10, Name = "Messi", Age = 17, Score = 88.0, Group = "R2" },
    new Student {Id = 11, Name = "Abduqodir", Age = 14, Score = 92.5, Group = "R1" },
    new Student {Id = 12, Name = "Sardor", Age = 16, Score = 80.0, Group = "R2" },
    new Student {Id = 13, Name = "Jonibek", Age = 20, Score = 85.5, Group = "R1" },
    new Student {Id = 14, Name = "G'ishmat", Age = 17, Score = 90.0, Group = "R2" }
];

// Where - bu operator yordamida biz ma'lum bir shartga javob beradigan elementlarni tanlab olishimiz mumkin. Masalan, biz R1 guruhidagi talabalarni tanlab olishimiz mumkin:

var result = students.Where(s => s.Age > 16 && s.Age < 18);
foreach (var student in result)
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Score: {student.Score}, Group: {student.Group}");
}

// Select - bu operator yordamida biz elementlarning ma'lum bir xususiyatlarini tanlab olishimiz mumkin. Masalan, biz talabalar nomlarini tanlab olishimiz mumkin:
var result2 = students.Select(_ => _.Name);
foreach (var name in result2)
{
    Console.WriteLine($"Name: {name}");
}
Console.WriteLine("\n");
var passedStudents = students.Where(s => s.Score >= 86).Select(s => s.Name);
foreach (var student in passedStudents)
{
    Console.WriteLine($"Passed Student: {student}");
}
Console.WriteLine("\n");

// OrderBy - bu operator yordamida biz elementlarni ma'lum bir xususiyatga ko'ra tartiblashtirishimiz mumkin. Masalan, biz talabalarni ballariga ko'ra tartiblashtirishimiz mumkin:
// OrderByDescending - bu operator yordamida biz elementlarni kamayish tartibida tartiblashtirishimiz mumkin. Masalan, biz talabalarni yoshlariga ko'ra kamayish tartibida tartiblashtirishimiz mumkin:
var sortedStudentsByScore = students.OrderByDescending(s => s.Age);
foreach (var student in sortedStudentsByScore)
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Score: {student.Score}, Group: {student.Group}");
}
Console.WriteLine("\n");

// Reverse - bu operator yordamida biz elementlarning tartibini teskari qilishimiz mumkin. Masalan, biz talabalarni nomlariga ko'ra teskari tartibda tartiblashtirishimiz mumkin:
var reversedStudents = students.Reverse<Student>();
foreach (var student in reversedStudents)
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Score: {student.Score}, Group: {student.Group}");
}
Console.WriteLine("\n");

// GroupBy - bu operator yordamida biz elementlarni ma'lum bir xususiyatga ko'ra guruhlashimiz mumkin. Masalan, biz talabalarni guruhlariga ko'ra guruhlashimiz mumkin:
var groupedStudents = students.GroupBy(s => s.Group);
foreach (var group in groupedStudents)
{
    Console.WriteLine($"Group: {group.Key}");
    foreach (var student in group)
    {
        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Score: {student.Score}, Group: {student.Group}");
    }
    Console.WriteLine("\n");
}
Console.WriteLine("\n");

// Any - bu operator yordamida biz ma'lum bir shartga javob beradigan elementlarning mavjudligini tekshirishingiz mumkin. Masalan, biz R1 guruhida 90 dan yuqori ballga ega bo'lgan talabalar mavjudligini tekshirishingiz mumkin:
var anyHighScoreInR1 = students.Any(s => s.Group == "R1" && s.Score > 90);
Console.WriteLine($"R1 guruhida 90 dan yuqori ballga ega bo'lgan talabalar mavjudmi? {anyHighScoreInR1}");
Console.WriteLine("\n");


// All - bu operator yordamida biz ma'lum bir shartga javob beradigan barcha elementlarning mavjudligini tekshirishingiz mumkin. Masalan, biz R1 guruhidagi barcha talabalar 80 dan yuqori ballga ega bo'lganligini tekshirishingiz mumkin:
bool allHighScoreInR1 = students.Where(s => s.Group == "R1").All(s => s.Score > 80);
Console.WriteLine($"R1 guruhidagi barcha talabalar 80 dan yuqori ballga ega bo'lganmi? {allHighScoreInR1}");
Console.WriteLine("\n");

// Contains - bu operator yordamida biz ma'lum bir elementning mavjudligini tekshirishingiz mumkin. Masalan, biz "Shahriyor" nomli talabani mavjudligini tekshirishingiz mumkin:
bool containsMessi = students.Select(s => s.Name).Contains("messi");
Console.WriteLine($"Messi nomli talaba mavjudmi? {containsMessi}");
Console.WriteLine("\n");


// Umumiy
var topGroup = students
    .Where(s => s.Score > 80)
    .OrderByDescending(s => s.Score)
    .GroupBy(s => s.Group)
    .Select(group => new
    {
        GroupName = group.Key,

        Students = group
            .Take(2)
            .Select(s => s.Name),

        AverageScore = group.Average(s => s.Score)
    });

foreach (var group in topGroup)
{
    Console.WriteLine($"Group: {group.GroupName}");
    Console.WriteLine("Top Students:");

    foreach (var student in group.Students)
    {
        Console.WriteLine($"- {student}");
    }

    Console.WriteLine($"Average Score: {group.AverageScore}");
    Console.WriteLine();
}