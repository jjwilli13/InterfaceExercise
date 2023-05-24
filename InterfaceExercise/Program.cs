using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        private static IEnumerable<object> cars;

        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE--Create 2 Interfaces called IVehicle & ICompany

            //DONE--Create 3 classes called Car , Truck , & SUV

            //DONE--In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //DONE--In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //DONE--In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            var mazda = new Car();

            mazda.Name = "Mazda";
            mazda.Motto = "Zoom Zoom..";
            mazda.Make = "Mazda";
            mazda.Model = "Mazda3";
            mazda.EngineType = "Gas";
            mazda.PassengerSeating = 4;
            mazda.SedanHatch = "Hatch";
            mazda.NumberofDoors = 4;

            var chevy = new Truck();

            chevy.Name = "Chevrolet";
            chevy.Motto = "Like a Rock..";
            chevy.Make = "Chevrolet";
            chevy.Model = "Silverado";
            chevy.EngineType = "Gas";
            chevy.PassengerSeating = 4;
            chevy.FourWheelDrive = true;
            chevy.EngineSize = 8;

            var toyota = new SUV();

            toyota.Name = "Toyota";
            toyota.Motto = "Let's go places..";
            toyota.Make = "Toyota";
            toyota.Model = "Sequoia";
            toyota.EngineType = "Gas";
            toyota.PassengerSeating = 7;
            toyota.ThirdRowSeating = true;
            toyota.RoofRack = true;

            //Creatively display and organize their values

            var cars = new List<Car>() { mazda };
            var trucks = new List<Truck>() { chevy };
            var suvs = new List<SUV>() { toyota };
            

            foreach (var car in cars)
            {
                Console.WriteLine($"Company name: {car.Name}");
                Console.WriteLine($"Company Motto: {car.Motto}");
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Engine Type: {car.EngineType}");
                Console.WriteLine($"Passegner Seating: {car.PassengerSeating}");
                Console.WriteLine($"Sedan or Hatch: {car.SedanHatch}");
                Console.WriteLine($"Doors: {car.NumberofDoors}");
                Console.WriteLine("---------------------------");

            }

            foreach (var truck in trucks)
            {
                Console.WriteLine($"Company name: {truck.Name}");
                Console.WriteLine($"Company Motto: {truck.Motto}");
                Console.WriteLine($"Make: {truck.Make}");
                Console.WriteLine($"Model: {truck.Model}");
                Console.WriteLine($"Engine Type: {truck.EngineType}");
                Console.WriteLine($"Passegner Seating: {truck.PassengerSeating}");
                Console.WriteLine($"Four Wheel Drive: {truck.FourWheelDrive}");
                Console.WriteLine($"Engine Size: {truck.EngineSize}");
                Console.WriteLine("---------------------------");

            }

            foreach (var suv in suvs)
            {
                Console.WriteLine($"Company name: {suv.Name}");
                Console.WriteLine($"Company Motto: {suv.Motto}");
                Console.WriteLine($"Make: {suv.Make}");
                Console.WriteLine($"Model: {suv.Model}");
                Console.WriteLine($"Engine Type: {suv.EngineType}");
                Console.WriteLine($"Passegner Seating: {suv.PassengerSeating}");
                Console.WriteLine($"Roof Rack: {suv.RoofRack}");
                Console.WriteLine($"Third Row: {suv.ThirdRowSeating}");
                Console.WriteLine("---------------------------");

            }





        }
    }
}
