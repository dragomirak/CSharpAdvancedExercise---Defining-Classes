namespace P08.CarSalesman;

public class StartUp
{
    static void Main()
    {
        List<Engine> engines = new List<Engine>();
        List<Car> cars = new List<Car>();

        int engineLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < engineLines; i++)
        {
            string[] engineTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string engineModel = engineTokens[0];
            int enginePower = int.Parse(engineTokens[1]);
            Engine engine = new(engineModel, enginePower);
            engines.Add(engine);

            if (engineTokens.Length > 2)
            {
                if (int.TryParse(engineTokens[2], out int result))
                {
                    engine.Displacement = result;
                }
                else
                {
                    string engineEfficiency = engineTokens[2];
                    engine.Efficiency = engineEfficiency;
                }
                
            }

            if (engineTokens.Length > 3)
            {
                string engineEfficiency = engineTokens[3];
                engine.Efficiency = engineEfficiency;
            }
        }

        int carsLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < carsLines; i++)
        {
            string[] carsTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string carModel = carsTokens[0];
            string engineModel = carsTokens[1];
            Engine carEngine = engines.FirstOrDefault(x => x.Model == engineModel);
            Car car = new(carModel, carEngine);
            cars.Add(car);

            if (carsTokens.Length > 2)
            {
                if (int.TryParse(carsTokens[2], out int result))
                {
                    car.Weight = result;
                }
                else
                {
                    string carColor = carsTokens[2];
                    car.Color = carColor;
                }
            }

            if (carsTokens.Length > 3)
            {
                string carColor = carsTokens[3];
                car.Color = carColor;
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}