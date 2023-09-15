namespace ConsoleAppNet7
{
    internal class OperatorsEg
    {
        string? name = null;           // variables assigned with ? is nullable       

        readonly string readVal = "ReadOnly";
        const string constVal = "Const Val";

        public void NullOperators()
        {
            string check = name ?? "Default Value";
            Console.WriteLine($"Value is {check}");

            //Ternary operator
            var isTrue = true;
            var value = isTrue ? "True Statement" : "False statement";
            Console.WriteLine($"Return value from Ternary Operator Usage: {value}");
        }
    }
}
