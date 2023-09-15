namespace ConsoleAppNet7
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Day2
            /* 
            LambdaFunction();

            UsingOperators();

            UsingParsing();

            UsingTuple();

            UsingStackAndQueue();
            */

            //Day1
            /* 
            UsingConstructorChaining();

            UsingCollections();

            UsingDictionaries();
            */
        }

        //Methods Usage for DAY2

        public static void UsingStackAndQueue()
        {
            StackandQueue stackandQueue = new StackandQueue();
            stackandQueue.StackProcess();
            stackandQueue.QueueProcess();
        }

        public static void UsingOperators()
        {
            OperatorsEg op = new OperatorsEg();
            op.NullOperators();
        }

        public static void UsingTuple()
        {
            TuplesClass tuplesClass = new TuplesClass();
            (var num1, var num2, var sum) = tuplesClass.SumWithNumber(1, 2);
            Console.WriteLine($"Sum of {num1} and {num2} is {sum}");
        }

        public static void UsingParsing()
        {
            ParsingClass parsingClass = new ParsingClass();
            parsingClass.ParsingMethods();
        }

        public static void LambdaFunction() => Console.WriteLine("Lambda function.");


        //Methods usage for DAY1

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

        /// <summary>
        /// Method for using constructor chainning
        /// </summary>
        public static void UsingConstructorChaining()
        {
            Person person = new Person("Joe");
            var id = person.Id;
            var name = person.Name;

            Console.WriteLine($"Id: {id} - Name: {name}");
        }

    }
}