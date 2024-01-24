using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace Jennifer_s_AudioManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nWelcome, know the sounds of these vehicles!\n");
                Console.WriteLine("\n\nTrain\tCar\tTruck\tRacecar\tmotorcycle\tTractor");
                Console.WriteLine("\nEnter the vehicle you want to listen to and then press enter: ");
                String vehicleType = Console.ReadLine().ToLower();

                if (ValideType(vehicleType))
                {
                    //creamos el objeto del vehiculo, llamando a la funcion Create
                    Vehicle vehicle = CreateVehicle(vehicleType);
                    if (vehicle != null)
                    {
                        vehicle.Sounds();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid vehicle! Please enter a valid vehicle");
                    System.Threading.Thread.Sleep(2000);
                }
            }
        }
    
        static bool ValideType(string vehicleType)
        {
            return vehicleType == "car" || vehicleType == "racecar" || vehicleType == "train" 
                || vehicleType == "truck" || vehicleType == "motorcycle" || vehicleType == "tractor";
        }

        static Vehicle CreateVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case "car":
                    Console.WriteLine("\nThis is the sound that a car makes");
                    return new Car();
                case "racecar":
                    Console.WriteLine("\nThis is the sound that a Race car makes");
                    return new Racecar();
                case "train":
                    Console.WriteLine("\nThis is the sound that a Train makes");
                    return new Train();
                case "truck":
                    Console.WriteLine("\nThis is the sound that a Truck makes");
                    return new Truck();
                case "motorcycle":
                    Console.WriteLine("\nThis is the sound that a Motorcycle makes");
                    return new Truck();
                case "tractor":
                    Console.WriteLine("\nThis is the sound that a Tractore makes");
                    return new Tractor();
                default:
                    return null;
            }
        }
    }
}