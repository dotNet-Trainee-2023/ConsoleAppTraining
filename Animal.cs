namespace ConsoleAppNet7
{
    internal class Animal<T>/* where T : class*/
    {
        public T Value { get; set; }

        public Animal(T value)
        {
            Value = value;
        }

        public void Display<K>(K value) where K : class
        {
            Console.WriteLine(value.GetType());
        }

        static void Main2(string[] args)
        {
            List<int> ints = new List<int>();
            List<string> strings = new List<string>();
            List<Person> people = new List<Person> { };

            //Animal<int> animal = new Animal<int>();
            //Animal<bool> animal1 = new Animal<bool>();

            Animal<string> animal = new Animal<string>("Dog");

            Animal<bool> animal1 = new Animal<bool>(true);

            Console.WriteLine(animal.Value);

            animal.Display<string>("display string");
            animal.Display<Person>(new Person());

            Console.WriteLine(animal1.Value);
        }
    }
}
