using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineType { get; set; }
        public int PassengerSeating { get; set; }
        public bool RoofRack { get; set; }
        public bool ThirdRowSeating { get; set; }
        public string Motto { get; set; }
        public string Name { get; set; }



    }
}

