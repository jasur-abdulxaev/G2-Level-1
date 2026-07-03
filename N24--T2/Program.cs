using N24__T2;

List<Student> talabalar = new List<Student>
{
    new Student { Id = 1, Name = "Asilbek Olimov", Age = 20, Group = "911-22", GPA = 4.2, City = "Toshkent" },
    new Student { Id = 2, Name = "Madina Rustamova", Age = 19, Group = "911-22", GPA = 4.8, City = "Samarqand" },
    new Student { Id = 3, Name = "Javohir Toshpulatov", Age = 21, Group = "912-22", GPA = 3.9, City = "Buxoro" },
    new Student { Id = 4, Name = "Dilnoza Karimova", Age = 22, Group = "913-21", GPA = 4.5, City = "Andijon" },
    new Student { Id = 5, Name = "Sardor Azimov", Age = 20, Group = "911-22", GPA = 3.6, City = "Farg'ona" },
    new Student { Id = 6, Name = "Laylo Aliyeva", Age = 19, Group = "914-22", GPA = 5.0, City = "Namangan" },
    new Student { Id = 7, Name = "Bekzod Shukurov", Age = 23, Group = "901-20", GPA = 3.2, City = "Qarshi" },
    new Student { Id = 8, Name = "Shahzoda Isoqova", Age = 21, Group = "912-22", GPA = 4.7, City = "Xiva" },
    new Student { Id = 9, Name = "Diyorbek Ergashev", Age = 20, Group = "913-22", GPA = 4.1, City = "Navoiy" },
    new Student { Id = 10, Name = "Gulnoza Hasanova", Age = 22, Group = "913-21", GPA = 4.4, City = "Guliston" },
    new Student { Id = 11, Name = "Otabek Rahimov", Age = 20, Group = "911-22", GPA = 3.8, City = "Jizzax" },
    new Student { Id = 12, Name = "Zilola Yusupova", Age = 19, Group = "914-22", GPA = 4.9, City = "Toshkent" },
    new Student { Id = 13, Name = "Jasur Mansurov", Age = 21, Group = "912-22", GPA = 3.5, City = "Termiz" },
    new Student { Id = 14, Name = "Malika Sultonova", Age = 22, Group = "915-21", GPA = 4.6, City = "Nukus" },
    new Student { Id = 15, Name = "Abdurashid Karimov", Age = 20, Group = "913-22", GPA = 4.0, City = "Samarqand" }
};

// GPA qiymati 4 dan katta bolgan talabalarni filterlash
var filteredStudents = talabalar.Where(student => student.GPA > 4).ToList();

foreach (var student in filteredStudents)
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, " +
        $"Group: {student.Group}, GPA: {student.GPA}, City: {student.City}");
}
Console.WriteLine("\n");

// Har bir talabani ismini katta katta harfga o'tkazish
var upperCaseNames = filteredStudents.Select(student => student.Name.ToUpper()).ToList();

foreach (var name in upperCaseNames)
{
    Console.WriteLine(name);
}
Console.WriteLine("\n");

// Talabalarni yoshi bo'yicha o'sish tartibida saralash
var ageSorted = talabalar.OrderBy(student => student.Age).ToList();

foreach (var student in ageSorted)
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, " +
        $"Group: {student.Group}, GPA: {student.GPA}, City: {student.City}");
}
Console.WriteLine("\n");

// Ro'yhatdagi birinchi talabani olish
var firstStudent = talabalar.FirstOrDefault();
if (firstStudent != null)
{
    Console.WriteLine($"Id: {firstStudent.Id}, Name: {firstStudent.Name}, Age: {firstStudent.Age}, " +
        $"Group: {firstStudent.Group}, GPA: {firstStudent.GPA}, City: {firstStudent.City}");
}
else
{
    Console.WriteLine("Talabalar ro'yhati bo'sh.");
}

Console.WriteLine("\n");

// Ro'yhatdagi jami talabalar sonini hisoblash
Console.WriteLine($"Jami talabalar soni: {talabalar.Count}");

Console.WriteLine("\n");

// Eng yuqori GPA ga ega talabani olish
var topStudent = talabalar.OrderByDescending(student => student.GPA).FirstOrDefault();
if (topStudent != null)
{
    Console.WriteLine($"Eng yuqori GPA ga ega talaba: {topStudent.Name}, GPA: {topStudent.GPA}");
}
else
{
    Console.WriteLine("Talabalar ro'yhati bo'sh.");
}
Console.WriteLine("\n");

// Talabalarni guruhlari bo'yicha guruhlash
var groups = talabalar.GroupBy(s => s.Group);

foreach (var group in groups)
{
    Console.WriteLine($"Guruh: {group.Key}");
    foreach (var student in group)
    {
        Console.WriteLine($"  Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, " +
            $"GPA: {student.GPA}, City: {student.City}");
    }
    Console.WriteLine();
}

Console.WriteLine("\n");





