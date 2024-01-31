using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.CarSalesman;

public class Car
{
    public Car(string model, Engine engine)
    {
        Model = model;
        Engine = engine;
    }

    public string Model { get; set; }
    public Engine Engine { get; set; }
    public int Weight { get; set; }
    public string Color { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Model}:");
        sb.AppendLine($"  {Engine.Model}:");
        sb.AppendLine($"    Power: {Engine.Power}");

        if (Engine.Displacement > 0)
        {
            sb.AppendLine($"    Displacement: {Engine.Displacement}");
        }
        else
        {
            sb.AppendLine("    Displacement: n/a");
        }

        if (Engine.Efficiency == null)
        {
            sb.AppendLine("    Efficiency: n/a");
        }
        else
        {
            sb.AppendLine($"    Efficiency: {Engine.Efficiency}");
        }

        if (Weight > 0)
        {
            sb.AppendLine($"  Weight: {Weight}");
        }
        else
        {
            sb.AppendLine("  Weight: n/a");
        }

        if (Color == null)
        {
            sb.AppendLine("  Color: n/a");
        }
        else
        {
            sb.AppendLine($"  Color: {Color}");
        }

        return sb.ToString().TrimEnd();
    }
}
