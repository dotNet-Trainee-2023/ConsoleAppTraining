namespace ConsoleAppNet7
{
    public class TuplesClass
    {
        public (int, int, int) SumWithNumber(int num1, int num2)
        {
            var sum = num1 + num2;
            return (num1, num2, sum);
        }
    }
}
