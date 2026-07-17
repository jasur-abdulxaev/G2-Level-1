using N30_T1.Interfaces;
using N30_T1.Models;

namespace N30_T1.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;

    // Repository DI orqali kiritiladi
    public StudentService(IStudentRepository repository)
    {
        _repository = repository;
    }

    public void Add(string fullName, int age, string group)
    {
        Validate(fullName, age, group);
        _repository.Add(new Student { FullName = fullName, Age = age, Group = group });
    }

    public void Delete(int id)
    {
        var student = GetById(id);
        _repository.Delete(student);
    }

    public List<Student> GetAll() => _repository.GetAll();

    public Student GetById(int id)
    {
        var student = _repository.GetById(id);
        if (student == null)
            throw new System.Exception("Xato");
        return student;
    }

    public void Update(int id, string fullName, int age, string group)
    {
        Validate(fullName, age, group);
        _repository.Add(new Student { FullName = fullName, Age = age, Group = group });
    }

    public void Validate(string fullName, int age, string group)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Ism-familiya bo'sh bo'lishi mumkun emas!");
        if (age < 0 || age > 100)
            throw new ArgumentException("Yosh noto'g'rin kiritildi!");
        if (string.IsNullOrWhiteSpace(group))
            throw new ArgumentException("Guruh nomi bo'sh bo'lishi mumkun emas!");
    }
}
