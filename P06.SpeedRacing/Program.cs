namespace P06.SpeedRacing
{
    public class Program
    {
        static void Main()
        {
            List<Car> cars = new();

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] carsInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new(carsInfo[0], double.Parse(carsInfo[1]), double.Parse(carsInfo[2]));
                cars.Add(car);
            }

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[1];
                int distanceToDrive = int.Parse(tokens[2]);
                Car carToDrive = cars.FirstOrDefault(c => c.Model == model);
                carToDrive.Drive(distanceToDrive);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}