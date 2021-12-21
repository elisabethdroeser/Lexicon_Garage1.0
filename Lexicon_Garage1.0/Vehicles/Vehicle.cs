namespace LexiconGarage1.Vehicles
{
    internal abstract class Vehicle
    {    
        protected int RegNo { get; set; } 
        public string? Name { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public int NumberOfWheel { get; set; }

        public Vehicle(int regNo, int numberOfWheel, string name, string model, string color)
        {
            RegNo = regNo;
            NumberOfWheel = numberOfWheel;
            Name = name;  
            Model = model;  
            Color = color;
        }
    }
}