using N26_T1;
using System.Text.Json;

// Yozish
Student student = new Student { Id = 1, FullName = "John Doe" };

string json = JsonSerializer.Serialize(student);
File.WriteAllText("D:\\Back End\\G2-Level-1\\N26-T1\\Student.txt", json);






