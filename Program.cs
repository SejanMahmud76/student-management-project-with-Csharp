

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
        set
        {
            //Exception Handling:

            if (value > DateTime.Now)
            {
                throw new ArgumentException
                ("Date of birth can not be in the future");
            }
            else
            {
                _dateofBirth = value;
            }
        }
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

    //calculate the age of the student based on the date of birth
    //creating the Method to calculate Age
    private int CalculateAge()
    {
        int age = DateTime.Now.Year - DateofBirth.Year;
        return age;
    }

    
    




}




// # Create a class: MyClass & Main method
public class MyClass
{

    public static void Main(string[] args)
    {
        //create at least two Student objects

        try
        {
            Student student1 = new Student("Rakibul Hasan Sezan", new DateTime(1999, 05, 16), "cse1802064");
            Student student2 = new Student("Arjon Golder", new DateTime(1998, 05, 16), "cse1802073");


            //Display the details of each student 
            Console.WriteLine($"Student Details: ");
            Console.WriteLine($"------------------");
            Console.WriteLine($"Name: {student1.Name},Date of Birth: {student1.DateofBirth.ToShortDateString()},Roll Number: {student1.RollNumber}");
            Console.WriteLine($"Name: {student2.Name},Date of Birth: {student2.DateofBirth.ToShortDateString()},Roll Number: {student2.RollNumber}");
            
            
            
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Error : {ex.Message}");

        }
    }

}