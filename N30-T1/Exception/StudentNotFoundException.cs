namespace N30_T1.Exception;

public class StudentNotFoundException : IOException
{
    public StudentNotFoundException(int id)
        : base($"ID={id} bo'lgan student topilmadi.") { }
}
