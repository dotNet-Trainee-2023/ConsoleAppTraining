namespace ConsoleAppNet7
{
    public class PersonDetails
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }

    public class LinqExamples
    {
        public void UsingLinq()
        {
            Console.WriteLine("-- LINQ Process --");
            // List of people - list of Person object.
            List<PersonDetails> people = new List<PersonDetails>() { new PersonDetails { Id = 1, Name = "Ram", Age = 23 } };

            // Adding a single person to the list.
            people.Add(new PersonDetails { Id = 2, Name = "Nitesh", Age = 26 });
            people.Add(new PersonDetails { Id = 3, Name = "Abhash", Age = 23 });

            // Another list of Person oject.
            List<PersonDetails> people2 = new List<PersonDetails>
            {
                new PersonDetails { Id = 4, Name = "Deepak", Age = 30 },
                new PersonDetails { Id = 5, Name = "Ganesh", Age = 28 },
            };

            // Adding the list of people2 to people list.
            // Adding a range of objects.
            people.AddRange(people2);

            // Order the list in ascending order by Age.
            IEnumerable<PersonDetails> orderedByAge = people.OrderBy(x => x.Age);

            // Order the list in descending order by Name.
            IEnumerable<PersonDetails> orderByDescName = people.OrderBy(x => x.Name);

            // Get the list of people where the age is greater than 25.
            IEnumerable<PersonDetails> ageGreaterThan25 = people.Where(x => x.Age > 25);

            foreach (PersonDetails p in ageGreaterThan25)
            {
                Console.WriteLine($"{p.Name} {p.Age}");
            }

            // Select only Name and Age from Person class and create a new List of PersonDetails class.
            var personDetails = people.Select(x => new PersonDetails { Name = x.Name, Age = x.Age })
                .Where(x => x.Age == 23).Skip(1).Take(2);

            foreach (PersonDetails p in personDetails)
            {
                Console.WriteLine(p.Name);
            }


            var groupByAge = people.GroupBy(x => x.Age);

            foreach (var key in groupByAge)
            {
                foreach (var p in key)
                {
                    Console.WriteLine($"Key: {key.Key} Name: {p.Name}");
                }
            }

            List<string> strings = new List<string>() { "a", "b", "c" };
            bool isC = strings.Contains("c");

            var pe1 = people.SingleOrDefault(x => x.Age == 25);
            var pe2 = people.Where(x => x.Age == 23).FirstOrDefault(x => x.Age == 25);
            var pe3 = people.LastOrDefault(x => x.Age == 25);
            var pe4 = people.First(x => x.Age == 25);
            var pe5 = people.Find(x => x.Age == 23);
            var pe6 = people.FindAll(x => x.Age == 23);
            Console.WriteLine(pe2.Name);

            bool is23 = people.Any(x => x.Age > 23);
            Console.WriteLine(is23);

            int count23 = people.Count(x => x.Age > 23);
            Console.WriteLine(count23);

            int sumAges = people.Sum(x => x.Age);
            Console.WriteLine(sumAges);

            double avgAge = people.Average(x => x.Age);
            Console.WriteLine(avgAge);

            int minAge = people.Min(x => x.Age);
            int maxAge = people.Max(x => x.Age);

            Console.WriteLine("-----");
        }
    }
}