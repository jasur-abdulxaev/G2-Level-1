using N30_T1.Interfaces;
using N30_T1.Models;
using System.Xml.Linq;

namespace N30_T1.Repositories;

public class TxtStudentRepository : IStudentRepository
{
    private readonly string _filePath;
    private List<Student> _students;

    public TxtStudentRepository(string filePath = "D:\\Back End\\G2-Level-1\\N30-T1\\Data\\students.txt")
    {
        _filePath = filePath;
        _students = Load();
    }

    public List<Student> GetAll() => _students;

    public Student? GetById(int id) => _students.FirstOrDefault(x => x.Id == id);

    public void Add(Student student)
    {
        student.Id = _students.Count == 0 ? 1 : _students.Max(x => x.Id) + 1;
        _students.Add(student);
        Save();
    }

    public void Update(Student student)
    {
        Save();
    }

    public void Delete(Student student)
    {
        _students.Remove(student);
        Save();
    }

    public void Save()
    {
        File.WriteAllLines(_filePath, _students.Select(s => s.ToFileLine()));
    }

    private List<Student> Load()
    {
        if (!File.Exists(_filePath))
            return new List<Student>();

        return File.ReadAllLines(_filePath)
            .Where(l => !string.IsNullOrWhiteSpace(l))
            .Select(Student.FromFileLine)
            .ToList();
    }
}