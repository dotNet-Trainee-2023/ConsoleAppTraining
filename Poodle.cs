namespace ConsoleAppNet7
{
    public class Poodle : Dog
    {
        public Poodle()
        {
            
        }

        public Poodle(int id) : base(id)
        {
            Console.WriteLine("Poodle cons");
        }

        public override void Bark()
        {
            Console.WriteLine("Poodle Bark");
        }
    }
}
