using System.Text;

namespace Builder;


// Product
// IBuilder
// ConcreteBuilder1, ConcreteBuilder2
// Director (Optional)



class Car
{
    public int Seats { get; set; }
    public double Engine { get; set; }
    public bool TripComputer { get; set; }
    public bool GPS { get; set; }

    public override string ToString()
    => $"Seats = {Seats}\nEngine{Engine}\nTripComputer{TripComputer}\nGPS{GPS}";
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

class WoodHouseBuilder : Bulider
{
    public Car car { get; set; } = new Car();

    public Bulider Engine(double engine)
    {
        car.Engine = engine; return this;
    }

    public Bulider GPS()
    {
        car.GPS = true; return this;
    }

    public void Reset() => car = new Car();
    public Car Result() => car;

    public Bulider Seats(int number)
    {
        car.Seats = number; return this;
    }

    public Bulider TripComputer()
    {
        car.TripComputer = true; return this;
    }
    //public House House { get; set; } = new House { Name = "WoodHouse" };

    //public IHouseBuilder BuildDoors(int count)
    //{
    //    House.Doors = count;
    //    return this;
    //}
    //public IHouseBuilder BuildGarage()
    //{
    //    House.HasGarage = true;
    //    return this;
    //}
    //public IHouseBuilder BuildGarden()
    //{
    //    House.HasGarden = true;
    //    return this;
    //}
    //public IHouseBuilder BuildPool()
    //{
    //    House.HasPool = true;
    //    return this;
    //}
    //public IHouseBuilder BuildRoof()
    //{
    //    House.HasRoof = true;
    //    return this;
    //}
    //public IHouseBuilder BuildWalls(int count)
    //{
    //    House.Walls = count;
    //    return this;
    //}
    //public IHouseBuilder BuildWindows(int count)
    //{
    //    House.Windows = count;
    //    return this;
    //}
    //public House Build() => House;

    //public void Reset() => House = new House();

}

//class StoneHouseBuilder : IHouseBuilder
//{
//    public House House { get; set; } = new House { Name = "StoneHouse" };

//    public IHouseBuilder BuildDoors(int count)
//    {
//        House.Doors = count;
//        return this;
//    }
//    public IHouseBuilder BuildGarage()
//    {
//        House.HasGarage = true;
//        return this;
//    }
//    public IHouseBuilder BuildGarden()
//    {
//        House.HasGarden = true;
//        return this;
//    }
//    public IHouseBuilder BuildPool()
//    {
//        House.HasPool = true;
//        return this;
//    }
//    public IHouseBuilder BuildRoof()
//    {
//        House.HasRoof = true;
//        return this;
//    }
//    public IHouseBuilder BuildWalls(int count)
//    {
//        House.Walls = count;
//        return this;
//    }
//    public IHouseBuilder BuildWindows(int count)
//    {
//        House.Windows = count;
//        return this;
//    }
//    public House Build() => House;

//    public void Reset() => House = new House();
//}
class Program
{
    static void Main()
    {

        Bulider builder = new WoodHouseBuilder();


        Car house = builder
            .Engine(23)
            .Seats(5)
            .TripComputer()
            .Result();

        Console.WriteLine(house);
    }
}
