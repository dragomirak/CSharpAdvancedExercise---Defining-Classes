namespace DefiningClasses;

public class StartUp
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        List<Person> people = new List<Person>();   

        for (int i = 0; i < lines; i++)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Person person = new Person(input[0], int.Parse(input[1]));
            people.Add(person);
        }

        List<Person> sortedPeople = people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();

        foreach (Person person in sortedPeople)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
        
    }
}