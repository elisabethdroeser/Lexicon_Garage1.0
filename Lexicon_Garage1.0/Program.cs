using LexiconGarage;
using LexiconGarage.Vehicles;
using System.Collections.Generic;

var garageManager = new GarageManager();
garageManager.Menu();
//garageManager.PrintAllVehicles();


var gh = new GarageHandler();
gh.SeedData();
gh.PrintAllVehicles();