namespace LexiconGarage.Vehicles;

internal class Motorcycle : Vehicle
{
    public int CylinderVolume { get; set; }

    public Motorcycle(string regNo, string name, string model, string color, int numberOfWheel, int cylinderVolume) : base(regNo, numberOfWheel, name, model, color)
    {
        CylinderVolume = cylinderVolume;
    }
}
