using System.Text;

namespace Builder;

class Car
{
    public string? Name { get; set; }
    public int Seats { get; set; }
    public double Engine { get; set; }
    public bool TripComputer { get; set; }
    public bool GPS { get; set; }
    public Car(string? name)
    {
        Name = name;
    }
    public override string ToString()
    => $"Name = {Name}\nSeats = {Seats}\nEngine{Engine}\nTripComputer{TripComputer}\nGPS{GPS}";
}


interface Bulider
{
    void Reset();
    Car car { get; set; }
    Bulider Seats(int number);
    Bulider Engine(double engine);
    Bulider TripComputer();
    Bulider GPS();
    Car Result();
}

class CarBuilder : Bulider
{
    public Car car { get; set; } = new Car("CarBulider");

    public Bulider Engine(double engine)
    {
        car.Engine = engine; return this;
    }

    public Bulider GPS()
    {
        car.GPS = true; return this;
    }

    public void Reset() => car = new Car(car.Name);
    public Car Result() => car;

    public Bulider Seats(int number)
    {
        car.Seats = number; return this;
    }

    public Bulider TripComputer()
    {
        car.TripComputer = true; return this;
    }

}

class CarManualBuilder : Bulider
{
    public Car car { get; set; } = new Car("CarManualBuilder");

    public Bulider Engine(double engine)
    {
        car.Engine = engine; return this;
    }

    public Bulider GPS()
    {
        car.GPS = true; return this;
    }

    public void Reset() => car = new Car(car.Name);
    public Car Result() => car;

    public Bulider Seats(int number)
    {
        car.Seats = number; return this;
    }

    public Bulider TripComputer()
    {
        car.TripComputer = true; return this;
    }

}

class Program
{
    static void Main()
    {

        Bulider builder = new CarBuilder();


        Car house = builder
            .Engine(23)
            .Seats(5)
            .TripComputer()
            .Result();

        Console.WriteLine(house);
    }
}
