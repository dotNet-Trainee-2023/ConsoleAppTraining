namespace ConsoleAppNet7
{
    internal class DictionaryClass
    {
        public void DictionaryUses()
        {
            Dictionary<string, string> names = new Dictionary<string, string>();

            names.Add("a", "b");
            names.Add("c", "d");
            names.Add("d", "e");

            names.Remove("c");

            Console.WriteLine(names["a"]);

            foreach (KeyValuePair<string, string> pair in names)
            {
                Console.WriteLine($"{pair.Key}, {pair.Value}");
            }
        }
    }
}
