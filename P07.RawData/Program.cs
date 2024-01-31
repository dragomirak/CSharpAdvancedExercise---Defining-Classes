namespace P07.RawData;

public class Program
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < lines; i++)
        {
            string[] carTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string model = carTokens[0];

            int engineSpeed = int.Parse(carTokens[1]);
            int enginePower = int.Parse(carTokens[2]);
            Engine engine = new Engine(engineSpeed, enginePower);

            int cargoWeight = int.Parse(carTokens[3]);
            string cargoType = carTokens[4];
            Cargo cargo = new(cargoWeight, cargoType);

            double tire1Pressure = double.Parse(carTokens[5]);
            int tire1Age = int.Parse(carTokens[6]);
            Tire tire1 = new(tire1Pressure, tire1Age);

            double tire2Pressure = double.Parse(carTokens[7]);
            int tire2Age = int.Parse(carTokens[8]);
            Tire tire2 = new(tire2Pressure, tire2Age);

            double tire3Pressure = double.Parse(carTokens[9]);
            int tire3Age = int.Parse(carTokens[10]);
            Tire tire3 = new(tire3Pressure, tire3Age);

            double tire4Pressure = double.Parse(carTokens[11]);
            int tire4Age = int.Parse(carTokens[12]);
            Tire tire4 = new(tire4Pressure, tire4Age);

            Car car = new(model, engine, cargo);
            car.Tires.Add(tire1);
            car.Tires.Add(tire2);
            car.Tires.Add(tire3);
            car.Tires.Add(tire4);

            cars.Add(car);
        }

        string filter = Console.ReadLine();
        if (filter == "fragile")
        {
            List<Car> resultList = cars.Where(c => c.Cargo.Type == filter).Where(c => c.Tires.Any(t => t.Pressure < 1)).ToList();
            foreach (Car car in resultList)
            {
                Console.WriteLine(car.Model);
            }
        }
        else if (filter == "flammable")
        {
            List<Car> resultList = cars.Where(c => c.Cargo.Type == filter).Where(c => c.Engine.Power > 250).ToList();
            foreach (Car car in resultList)
            {
                Console.WriteLine(car.Model);
            }
        }


    }
}