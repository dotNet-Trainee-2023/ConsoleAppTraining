namespace ConsoleAppNet7
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Method for use of Constructor Chainning
            Console.WriteLine("Method for use of Constructor Chaining");
            UsingConstructorChaining();
            Console.WriteLine("--------------------------------------");

            //Method for use of Collections
            Console.WriteLine("Method for use of Collections");
            UsingCollections();
            Console.WriteLine("--------------------------------------");

            //Method for use of dictionary
            Console.WriteLine("Method for use of dictionary");
            UsingDictionaries();
            Console.WriteLine("--------------------------------------");

        }

        public static void UsingConstructorChaining()
        {
            Person person = new Person("Joe");
            var id = person.Id;
            var name = person.Name;

            Console.WriteLine($"Id: {id} - Name: {name}");
        }

        public static void UsingCollections()
        {
            Collections collections = new Collections();
            collections.CollectionsUses();
        }

        public static void UsingDictionaries() 
        { 
            DictionaryClass dictionaryClass = new DictionaryClass();
            dictionaryClass.DictionaryUses();
        }

    }
}