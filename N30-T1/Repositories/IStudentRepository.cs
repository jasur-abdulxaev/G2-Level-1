using N30_T1.Models;

namespace N30_T1.Interfaces;

public interface IStudentRepository
{
    List<Student> GetAll();
    Student? GetById(int id);
    void Add(Student student);
    void Update(Student student);
    void Delete(Student student);
}
