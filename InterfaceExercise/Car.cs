using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }

        public string Make { get; set; } 
        public string Model { get; set; } 
        public string EngineType { get; set; } 
        public int PassengerSeating { get; set; } 
        public string SedanHatch { get; set; } 
        public int NumberofDoors { get; set; } 
        public string Motto { get; set; }
        public string Name { get; set; }



    }
}

