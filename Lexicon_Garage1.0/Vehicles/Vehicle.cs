namespace Lexicon_Garage1._0.Vehicles
{
    internal class Vehicle
    {
        private int regNo;

        public int RegNo { get; set; }

        public string? name;

        public string? Name;

        private string? model;

        public string? Model { get; set; }

        private string? color;

        public string? Color { get; set; }

        private int numberOfWheel;

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
