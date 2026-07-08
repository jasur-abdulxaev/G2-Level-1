List<string> students = new List<string>
{
    "Ali", "Vali", "Hasan", "Husan", "Olim",
    "Sherbek", "Alijon", "Oydinoy", "Bobur"
};

// Metodga ro'yxatni parametr sifatida uzatamiz
List<string> result = await GetFilteredStudentsAsync(students);

Console.WriteLine("Natijalar: ");
foreach (var item in result)
{
    Console.WriteLine($"- {item}");
}

// Metodni ham shu faylning pastiga static qilib yozib qo'yish mumkin (yoki alohida faylda)
static async Task<List<string>> GetFilteredStudentsAsync(List<string> studentList)
{
    Console.WriteLine("Malumotlar yuklanmoqda...");
    await Task.Delay(5000); // 5 soniya kutish

    var filtered = studentList
        .Where(s => s.Length > 4)
        .OrderBy(s => s)
        .ToList();

    return filtered;
}