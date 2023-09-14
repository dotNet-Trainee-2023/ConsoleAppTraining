namespace ConsoleAppNet7
{
    public class Collections
    {
        public void CollectionsUses()
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };
            List<string> strList = new List<string> { "a" };
            numbersList.Add(6);
            numbersList.Add(7);
            numbersList.AddRange(new List<int> { 10, 11 });

            numbersList.Remove(7);
            numbersList.RemoveAt(0);

            var greaterThan5 = numbersList.Where(x => x > 5);

            var find5 = numbersList.Find(x => x == 15);
            //Console.WriteLine(find5);

            var find6 = strList.FirstOrDefault(x => x == "b");
            Console.WriteLine(find6);

            List<string> list = new List<string>();
            IList<string> list2 = new List<string>();
            ICollection<string> collection = new List<string>();
            IEnumerable<string> enumerable = new List<string>();
        }
    }
}
