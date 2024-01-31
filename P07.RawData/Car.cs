using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.RawData;

public class Car
{
    private List<Tire> tires = new List<Tire>(4);
    public Car(string model, Engine engine, Cargo cargo)
    {
        Model = model;
        Engine = engine;
        Cargo = cargo;
        Tires = new List<Tire>(4);
       
    }

    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }

    public List<Tire> Tires { get; set; }



}
