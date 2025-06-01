

/*
## Student Class Definition:
    Private Fields:
        name (string)
        dateOfBirth (DateTime)
        rollNumber (string)
*/
public class Student
{
    private string? _name;

    private DateTime _dateofBirth;

    private string? _rollNumber;



    // Implementing appropriate access modifiers set,get

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


    //Create a constructor to initialize the name, dateOfBirth, and rollNumber of the student

    public Student(string name, DateTime dateofBirth, string rollNumber)
    {
        Name = name;
        DateofBirth = dateofBirth;
        RollNumber = rollNumber;


    }



}




// # Create a class: MyClass & Main method
public class MyClass
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Bismillahir rahmanir Rahim");
    }

}