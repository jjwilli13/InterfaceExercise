using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineType { get; set; }
        public int PassengerSeating { get; set; }
        public bool FourWheelDrive { get; set; }
        public int EngineSize { get; set; }
        public string Motto { get; set; }
        public string Name { get; set; }


    }
}

