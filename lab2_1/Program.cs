class Adress
{
    private string index;
    public string Index
    {
        get { return index; }
        set { index = value; }
    }
    private string country;
    public string Country
    {
        get { return country; }
        set { country = value; }
    }
    private string city;
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    private string street; 
    public string Street
    {
        get { return street; }
        set { street = value; }
    }
    private int house;
    public int House
    {
        get { return house; }
        set { house = value; }
    }
    private string apartment;
    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
    public string Get()
    {
        return $" Index: {index};\n Country: {country};\n City: {city};\n Street: {street};\n House: {house};\n Apartment: {apartment};";
    }
    class Program
    {
        static void Main()
        {
            Adress program = new Adress();
            Console.WriteLine(new string('-', 50));
            program.Index = "02000";
            Console.WriteLine(program.Index);
            Console.WriteLine(new string('-', 50));
            program.Country = "Ukraine";
            Console.WriteLine(program.Country);
            Console.WriteLine(new string('-', 50));
            program.City = "Kyiv";
            Console.WriteLine(program.City);
            Console.WriteLine(new string('-', 50));
            program.Street = "Kyoto Street";
            Console.WriteLine(program.Street);
            Console.WriteLine(new string('-', 50));
            program.House = 19;
            Console.WriteLine(program.House);
            Console.WriteLine(new string('-', 50));
            program.Apartment = "Building D";
            Console.WriteLine(program.Apartment);
            Console.WriteLine(new string('-', 50));
            Console.ReadKey();

        }
    }
}


