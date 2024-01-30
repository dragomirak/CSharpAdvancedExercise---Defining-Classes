namespace P05.DateModifier;

public class Program
{
    static void Main()
    {
        string[] dates = new string[2];
        for (int i = 0; i < dates.Length; i++)
        {
            dates[i] = Console.ReadLine();
        }

        DateModifier dateModifier = new(dates[0], dates[1]);
        Console.WriteLine(dateModifier.DifferenceInDays);

    }
}