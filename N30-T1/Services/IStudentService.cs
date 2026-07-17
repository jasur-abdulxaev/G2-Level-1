using N30_T1.Models;

namespace N30_T1.Services;

public interface IStudentService
{
    List<Student> GetAll();
    Student GetById(int id);
    void Add(string fullName, int age, string group);
    void Update(int id, string fullName, int age, string group);
    void Delete(int id);
}
