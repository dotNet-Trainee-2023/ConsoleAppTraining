namespace ConsoleAppNet7
{
    /// <summary>
    /// Person class
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Property for Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Property for name
        /// </summary>
        public string Name { get; set; }

        //Default Constructor
        public Person() { }

        /// <summary>
        /// Constructor with only Id
        /// </summary>
        /// <param name="id"></param>
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

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="person"></param>
        public Person(Person person)
        {
            Id = person.Id;
            Name = person.Name;
        }

        /// <summary>
        /// Constructor with id and name
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Person(int id, string name) { 
            Id = id; 
            Name = name; 
        }

        /// <summary>
        /// Display Method for name.
        /// </summary>
        public void DisplayName()
        {
            Console.WriteLine($"Name is {Name}");
        }

        /// <summary>
        /// Getter method for Id.
        /// </summary>
        /// <returns></returns>

        public int GetId()
        {
            return Id;
        }

    }
}
