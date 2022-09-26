class User
{
    public string login = "olehvolosatskyi@gmail.com";
    public string name = "Oleh";
    public string surname = "Volosatskyi";
    public int age = 18;
    public readonly DateTime date = DateTime.Now;


    public User(string loginx, string namex, string surnamex, int agex)
    {
        loginx = login;
        namex = name;
        surnamex = surname;
        agex = age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User solution\n");

            User ezUser = new User("olehvolosatskyi@gmail.com", "Oleh", "Volosatskyi", 18);

            Console.WriteLine(ezUser.login);
            Console.WriteLine(ezUser.name);
            Console.WriteLine(ezUser.surname);
            Console.WriteLine(ezUser.age);
            Console.WriteLine(ezUser.date);

            Console.ReadKey();
        }
    }
}