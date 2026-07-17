namespace N30_T1.Models;

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }

    public string ToFileLine() => $"{Id}|{FullName}|{Age}|{Group}";

    public static Student FromFileLine(string line)
    {
        var parts = line.Split('|');
        return new Student
        {
            Id = int.Parse(parts[0]),
            FullName = parts[1],
            Age = int.Parse(parts[2]),
            Group = parts[3]
        };
    }

    public override string ToString() => $"[{Id}] {FullName}, {Age} yosh, {Group}-guruh";
}
