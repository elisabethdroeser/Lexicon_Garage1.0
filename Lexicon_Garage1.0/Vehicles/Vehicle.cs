namespace LexiconGarage1.Vehicles;

internal abstract class Vehicle
{
    public string RegNo { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int NumberOfWheel { get; set; }

    public override string ToString() => $"RegNo: {RegNo}, Name: {Name}"; 

    public Vehicle(string regNo, int numberOfWheel, string name, string model, string color)
    {
        RegNo = regNo;
        NumberOfWheel = numberOfWheel;
        Name = name;
        Model = model;
        Color = color;
    }
}
