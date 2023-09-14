namespace ConsoleAppNet7
{
    public class Dog : IDog
    {
        public string Name { get; set; } = string.Empty;

        public Dog()
        {
            Console.WriteLine();
        }

        public Dog(int id)
        {
            Console.WriteLine(id);
        }

        public virtual void Bark()
        {
            Console.WriteLine("Bark");
        }

        public void Run()
        {
            Console.WriteLine("Run");
        }

        public void GetName()
        {
        }
    }
}
