

// Konstantalar
const string CompanyName = "The Travel Guru";
const string NameToken = "{{Name}}";
const string CompanyNameToken = "{{CompanyName}}";
const string TicketDateToken = "{{TicketDate}}";

// Xabarlar
Dictionary<string, string> messages = new Dictionary<string, string>()
{
    { "UnderAge", "Uzr, hurmatli {{Name}} siz loyihadan foydalanish uchun kichkinasiz"},
    {"GoldenAger", "Uzr, hurmatli {{Name}} loyiha yoshlar uchun mo'ljallangan" }
};

// Emaillar
LinkedList<string> emails = new LinkedList<string>();
emails.AddLast("Hello {{Name}}. Welcome to onboard. {{CompanyName}} Team");
emails.AddLast("Your data is being processed and we will inform updates. {{CompanyName}}");
emails.AddLast("Congratulation! You flight ticket is booked for {{TicketDate}}. {{CompanyName}} Team");

// Oldindan ro'yhatdan o'tgan foydalanuvchilar
List<string> registeredusers = new List<string>() { "Sherbek", "Iqbol", "Oydinoy", "Alijon" };

// Parvoz vaqatlari va bo'sh o'rinlar
Dictionary<string, int> flight = new Dictionary<string, int>()
{
    {"2026-06-20 08:00", 7 },
    {"2026-06-19 20:00", 4 },
    {"2026-06-21 05:00", 3 }
};

// Ro'yhatdan o'tish jarayoni
Console.WriteLine("=== Ro'yxatdan o'tish jarayoni ===");

string myName = "";
while (true)
{
    Console.Write("Ismingizni kiriting: ");
    myName = Console.ReadLine();

    if (HasDigit(myName))
    {
        Console.WriteLine("Invalid name");
        continue;
    }
    break;
}

Console.WriteLine("Yoshingizni kiriting: ");
string ageInput = Console.ReadLine();
int myAge;
bool isNumber = int.TryParse(ageInput, out myAge);

if (!isNumber)
{
    Console.WriteLine("Invalid Age");
    return;
}

if (myAge < 18)
{
    string underageMessage = messages["UnderAge"].Replace(NameToken, myName);
    Console.WriteLine(underageMessage);
    return; //dastur yopiladi
}

if (myAge >= 90)
{
    string goldenMessage = messages["GoldenAger"].Replace(NameToken, myName);
    Console.WriteLine(goldenMessage);
    return; //dastur yopiladi
}

Console.WriteLine("Ro'yxatdan muvaffaqqiyatli o'tdingiz, " + myName + "!");

// Guruhga o'zimizni ham qoshib qoyamiz
registeredusers.Add(myName);

Console.WriteLine();
Console.WriteLine("Guruhimiz azolari:");
for (int i = 0; i < registeredusers.Count; i++)
{
    Console.WriteLine((i + 1) + ". " + registeredusers[i]);
}

// Biletlar olish


// Loyihani boshlar



// Yordamchi method
static bool HasDigit(string text)
{
    foreach (char c in text)
    {
        if (char.IsDigit(c))
        {
            return true;
        }
    }
    return false;
}










