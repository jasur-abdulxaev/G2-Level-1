using Microsoft.Extensions.DependencyInjection;
using N30_T1.Exception;
using N30_T1.Interfaces;
using N30_T1.Repositories;
using N30_T1.Services;

var services = new ServiceCollection();
services.AddSingleton<IStudentRepository>(new TxtStudentRepository("D:\\Back End\\G2-Level-1\\N30-T1\\Data\\students.txt"));
services.AddSingleton<IStudentService, StudentService>();

var provider = services.BuildServiceProvider();
var studentService = provider.GetRequiredService<IStudentService>();

RunMenu(studentService);

void RunMenu(IStudentService service)
{
    while (true)
    {
        Console.WriteLine("\n===== STUDENT CRUD =====");
        Console.WriteLine("1 - Barchasini ko'rish");
        Console.WriteLine("2 - Qo'shish");
        Console.WriteLine("3 - Yangilash");
        Console.WriteLine("4 - O'chirish");
        Console.WriteLine("0 - Chiqish");
        Console.Write("Tanlov: ");

        try
        {
            switch (Console.ReadLine())
            {
                case "1":
                    var all = service.GetAll();
                    if (all.Count == 0) Console.WriteLine("Studentlar mavjud emas.");
                    foreach (var s in all) Console.WriteLine(s);
                    break;

                case "2":
                    Console.Write("Ism-familiya: ");
                    var name = Console.ReadLine();
                    Console.Write("Yosh: ");
                    var age = int.Parse(Console.ReadLine());
                    Console.Write("Guruh: ");
                    var group = Console.ReadLine();
                    service.Add(name, age, group);
                    Console.WriteLine("Qo'shildi.");
                    break;

                case "3":
                    Console.Write("Yangilanadigan ID: ");
                    var updId = int.Parse(Console.ReadLine());
                    Console.Write("Yangi ism: ");
                    var newName = Console.ReadLine();
                    Console.Write("Yangi yosh: ");
                    var newAge = int.Parse(Console.ReadLine());
                    Console.Write("Yangi guruh: ");
                    var newGroup = Console.ReadLine();
                    service.Update(updId, newName, newAge, newGroup);
                    Console.WriteLine("Yangilandi.");
                    break;

                case "4":
                    Console.Write("O'chiriladigan ID: ");
                    var delId = int.Parse(Console.ReadLine());
                    service.Delete(delId);
                    Console.WriteLine("O'chirildi.");
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Noto'g'ri tanlov.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Xato: raqam noto'g'ri kiritildi.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Validatsiya xatosi: {ex.Message}");
        }
        catch (StudentNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}