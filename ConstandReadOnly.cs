namespace ConsoleAppNet7
{
    public class ConstandReadOnly
    {
        public readonly string name = "John Doe";

        const string anotherName = "John Smith";

        public ConstandReadOnly() { 
        }

        public ConstandReadOnly(string name)
        {
            //Can be assigned from constructor -- runtime
            this.name = name;
            
            //can't assign value in const.
            //anotherName = name;
        }

        public void ReadOnlyAndConst()
        {
            //Assigning value to readonly variable is not possible
            //name = "Joe";

        }
    }
}
