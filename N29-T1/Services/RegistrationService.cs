using N29_T1.Interfaces;
using N29_T1.Models;
using N29_T1.Validators;

namespace N29_T1.Services;

public class RegistrationService : IRegistrationService
{
    private readonly IRepository<User> _repository;
    private readonly UserValidator _validator;

    public void Register(string email, string password)
    {
        var existingUser = _repository.Find(u => u.EmailAddress == email);

        if (existingUser == null)
        {
            Console.WriteLine("Bu email allaqachon bor!");
        }

        var user = new User
        {
            EmailAddress = email,
            Password = password,
            IsEmailVerified = false,
            IsPhoneVerified = false
        };

        if (!_validator.Validate(user, out string error))
        {
            Console.WriteLine(error);
            return;
        }

        _repository.Add(user);
        Console.WriteLine("User muvaffaqqiyatli qo'shildi");
    }

    public bool Login(string email, string password)
    {
        var user = _repository.Find(u =>
        u.EmailAddress == email &&
        u.Password == password);

        if (user == null)
        {
            Console.WriteLine("Email yoki password noto'g'ri");
            return false;
        }

        if (!user.IsEmailVerified || !user.IsPhoneVerified)
        {
            Console.WriteLine("Kechirasiz bu email bilan boshqa foydalamuvchi ro'yxatdan otkan");
            return false;
        }

        return true;
    }
}
