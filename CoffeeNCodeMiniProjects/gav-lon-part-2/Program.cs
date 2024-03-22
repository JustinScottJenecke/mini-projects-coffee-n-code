class Employee 
{
    public static void Main()
    {
        int employeeId = 0;
        string firstName = String.Empty;
        string lastName = String.Empty;
        decimal salary = 0;
        char gender = '\0';
        bool isManager = true;

        Console.WriteLine("Please eneter a unique id for this employee:");
        employeeId = Convert.ToInt32( Console.ReadLine() );

        Console.WriteLine("Please enter a first name for this employee:");
        firstName = Console.ReadLine();

        Console.WriteLine("Please enter a last name for this employee:");
        lastName = Console.ReadLine();

        Console.WriteLine("Please enter this employee'a annual salary:");
        salary = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter a gender for this employee");
        gender = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Is this employee a manager? (true/false)");
        isManager = Convert.ToBoolean(Console.ReadLine());

        string managerString = isManager ? "is a manager" : "is not a manager";
        string genderString = (gender == 'm') ? "Male" : "Female";


        string output = "" +
            "===== Employee: ===== \n" +
            $"ID: {employeeId} \n" +
            $"Fullname: {firstName} {lastName} \n" +
            $"Gender: {genderString} \n" +
            $"Employee {managerString} who earns {salary} annually.";

        Console.WriteLine();
        Console.WriteLine(output);
        Console.ReadKey();
    }
}
