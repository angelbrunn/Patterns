using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class CarBody
    {
        public void AddCarBody()
        {
            Console.WriteLine("  >> CarBody AddCarBody");
        }
    }

    class WheelSystem
    {
        public void AddWheelSystem()
        {
            Console.WriteLine("  >> WheelSystem AddWheelSystem");
        }
    }

    class ChassisSystem
    {
        public void AddChassisSystem()
        {
            Console.WriteLine("  >> ChassisSystem AddChassisSystem");
        }
    }

    class SteeringSystem
    {
        public void AddSteeringSystem()
        {
            Console.WriteLine("  >> SteeringSystem AddSteeringSystem");
        }
    }

    class CarFacade
    {
        CarBody car;
        WheelSystem wheel;
        ChassisSystem chassis;
        SteeringSystem steering;

        public CarFacade()
        {
            car = new CarBody();
            wheel = new WheelSystem();
            chassis = new ChassisSystem();
            steering = new SteeringSystem();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("Creating Car");
            car.AddCarBody();
            wheel.AddWheelSystem();
            chassis.AddChassisSystem();
            steering.AddSteeringSystem();
            Console.WriteLine("Car creation complete");
        }
    }
}
