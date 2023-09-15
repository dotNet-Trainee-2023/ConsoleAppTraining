namespace ConsoleAppNet7
{
    public class MultipleInheritance : IAge, IHeight
    {
        public int Age { get; set; }

        public double Height { get; set; }

        //Use of Constructor Chainning
        public MultipleInheritance() : this(18, 5.6)
        {

        }

        public MultipleInheritance(int age, double height)
        {
            Age = age;
            Height = height;
        }

        public void DisplayAge()
        {
            Console.WriteLine($"Age is: {Age}");
        }

        public void DisplayHeight()
        {
            Console.WriteLine($"Height is: {Height}");
        }
    }
}
