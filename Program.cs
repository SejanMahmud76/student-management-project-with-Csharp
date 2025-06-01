
public class Student
{
    private string? _name;

    private DateTime _dateofBirth;

    private string? _rollNumber;





    public string? Name
    {
        set { _name = value; }
        get { return _name; }
    }

    public DateTime DateofBirth
    {
        set { _dateofBirth = value; }
        get { return _dateofBirth; }
    }
    
    public string? RollNumber
    {
        set { _rollNumber = value; }
        get { return _rollNumber; }
    }

}




public class MyClass
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Bismillahir rahmanir Rahim");
    }

}