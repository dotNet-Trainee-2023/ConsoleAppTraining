namespace ConsoleAppNet7
{
    public class ParsingClass
    {
        public void ParsingMethods() 
        { 
            var valueInString = "1";
            int valueInInt = int.Parse(valueInString);
            Console.WriteLine($"Int value: {valueInInt}");

            //Using Try Parse;
            var stringValue = "Hello";
            int tryParseValue;
            bool isTrue = int.TryParse(stringValue, out tryParseValue);

            Console.WriteLine($"Before - Parsing done? : {isTrue} & int value: {tryParseValue}");

            stringValue = "10";
            isTrue = int.TryParse(stringValue, out tryParseValue);
            Console.WriteLine($"After - Parsing done? : {isTrue} & int value: {tryParseValue}");
        }
    }
}
