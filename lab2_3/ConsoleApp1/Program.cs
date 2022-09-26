class Employee
{
    private string first;
    private string last;
    private string pos = "middle";
    private int exp = 5;
    private int salary;
    private int tax = 10;


    public Employee(string firstName, string lastName)
    {
        first = firstName;
        last = lastName;
    }

    public void Calculate()
    {

        if (pos == "junior" || pos == "Junior")
        {
            salary = (int)((int)700 * (exp * 0.15) * 0.9);
        }
        else if (pos == "middle" || pos == "Middle")
        {
            salary = (int)((int)1300 * (exp * 0.3) * 0.9);
        }
        else if (pos == "senior" || pos == "Senior")
        {
            salary = (int)((int)2500 * (exp * 0.5) * 0.9);
        }
        else
        {
            pos = "trainee";
            exp = 0;
            salary = 700;
        }
    }


    public void Write()
    {
        Console.WriteLine($"Name: {first} \nLast Name: {last} \nPosition: {pos} \nExpirience: {exp} years" +
            $" \nSalary: {salary}$ \nTax collection: {tax}%");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee solution\n");

            Employee lezhok = new Employee("Oleh", " Volosatskyi");

            lezhok.Calculate();

            lezhok.Write();

            Console.ReadKey();
        }
    }
}
