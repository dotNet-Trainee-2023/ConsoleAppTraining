namespace ConsoleAppNet7
{
    /// <summary>
    /// Person class
    /// </summary>
    public class Person : IAge, IHeight
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Person() { }

        public Person(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Constructor chainning. Create object with only name will provide default Id of 10
        /// </summary>
        /// <param name="name"></param>
        public Person(string name) : this(10)
        {
            Name = name;
        }

        // Copy Constructor
        public Person(Person person)
        {
            Id = person.Id;
            Name = person.Name;
        }

        public Person(int id, string name) { 
            Id = id; 
            Name = name; 
        }

        public void DisplayName()
        {
            Console.WriteLine($"Name is {Name}");
        }

        public int GetId()
        {
            return Id;
        }

        //Method Overloading
        public void DisplayAgeNew()
        {
            Console.WriteLine("Default Age is 18");
        }

        //Method Overloading
        public void DisplayAgeNew(int age)
        {
            Console.WriteLine("Age is "+age);
        }

        public void DisplayAge()
        {
            Console.WriteLine();
        }

        public void DisplayHeight()
        {
            Console.WriteLine();
        }


    }
}
