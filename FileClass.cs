namespace ConsoleAppNet7
{
    internal class FileClass
    {
        public void Test()
        {
            string text = "Hello";

            List<string> texts = new List<string>();
            texts.Add("Hello");
            texts.Add("Hi");

            Directory.CreateDirectory("D:/files");

            File.WriteAllText("D:/files/files.txt", text);
            File.AppendAllText("D:/files/files.txt", "\nHi");

            File.Copy("D:/files/files.txt", "D:/files/test.txt");
            File.Delete("D:/files/files.txt");

            File.WriteAllLines("D:/files2.txt", texts);

            string readFromFile = File.ReadAllText("D:/files.txt");
            string[] readFromFiles = File.ReadAllLines("D:/files2.txt");

            Console.WriteLine(readFromFile);

            foreach (var line in readFromFiles)
            {
                Console.WriteLine(line);
            }

            FileStream fileStream = new FileStream(@"D:\files.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine("Hello");
            writer.Close();
            fileStream.Close();
        }
    }
}
