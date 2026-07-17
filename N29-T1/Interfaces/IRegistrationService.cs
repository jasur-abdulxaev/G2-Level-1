namespace N29_T1.Interfaces;

public interface IRegistrationService
{
    void Register(string email, string password);
    bool Login(string email, string password);
}
