﻿namespace LexiconGarage1.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public int CylinderVolume { get; set; }

        public Motorcycle(int regNo, string name, string model, string color, int numberOfWheel, int cylinderVolume) : base(regNo, numberOfWheel, name, model, color)
        {
            CylinderVolume = cylinderVolume;
        }
    }
}