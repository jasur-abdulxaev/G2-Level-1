namespace N23_T1;
/*
// muammo int uchun alohida, string uchun alohida ochdik
public class IntBox
{
    public int Value { get; set; }
}

public class StringBox
{
    public string Value { get; set; }
}
*/

public class Box<T>
{
    public T Value { get; set; }

    public Box(T value)
    {
        Value = value;
    }
    
    public void Show()
    {
        Console.WriteLine($"Value: {Value}, Type: {typeof(T).Name}");
    }
}
