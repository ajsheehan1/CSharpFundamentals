using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat, Submarine }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }

        public string Color { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle()
        {
            Year = 1990;
            Color = "Default Color";
        }

        // below is a Constructor, this assigns all values to new 'vehicles'.
        public Vehicle(string make, string model, int year, double mileage, string color, VehicleType tOV)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            Color = color;
            TypeOfVehicle = tOV;
        }

    }

    public class Person
    {
        public string FirstName { get; set; }
        private string _lastName;

        //propfull shortcut (expanded get/set \/\/\/) 
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        { get { return $"{FirstName} {LastName}"; } }

        public DateTime DateofBirth { get; set; }

        public int AgeInYears
        {
            get
            {
                if (DateofBirth == new DateTime())
                {
                    return 9001;
                }
                TimeSpan ageSpan = DateTime.Now - DateofBirth;
                double totalAgeInYear = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYear));
            }
        }


        // creating a vehicle object and saving it as a transport property of a person
        public Vehicle Transport { get; set; }

        public Person(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            DateofBirth = birthday;
        }
    }

    class ClassExamples
    {

    }
}
