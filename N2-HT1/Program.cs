
string name;
string secondName;
byte age;

Console.Write("Ismingizni kiriting: ");
name = Console.ReadLine();

Console.Write("Otangizni ismi: ");
secondName = Console.ReadLine();

Console.Write("Yoshingizni kiriting: ");
age = byte.Parse(Console.ReadLine());

Console.WriteLine($"Ismingiz: {name}, Otangizni ismi: {secondName}, Yoshingiz: {age}");


