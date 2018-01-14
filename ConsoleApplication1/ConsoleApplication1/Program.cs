using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("NF123456", "147 kW", "200 km/h", "green", "personal vehicle");
            car1.carInfo();

            Car car2 = new Car("NF654321", "150 kW", "195 km/h", "blue", "personal vehicle");
            car2.carInfo();
            //registration LN1234, 1000 kW engine power, 30m wingspan, 2t load capacity and 10t net weight, flying class of jet plane
            Plane plane1 = new Plane("LN1234", "1000 kW", "30m", "2t", "10t", "jet plane");
            plane1.planeInfo();
            // registration ABC123, 100 kW engine power, maximal speed of 30 knot per hour and 500 kg gross tonnage
            Boat boat1 = new Boat("ABC123", "100 kW", "30 knot per hour", "500 kg");
            boat1.boatInfo();

            CompareTrans campare1 = new CompareTrans(car1.license, car2.license);
            campare1.printResult();

            car1.drive();
            plane1.fly();
            Console.ReadKey();
        }
    }
    class Transportation
    {
        public string license;
        public string enginePower;
        public string maxSpeed;
    }
    class Car : Transportation
    {

        private string color;
        private string type;
        public Car(string license, string enginePower, string maxSpeed, string color, string type)
        {
            this.license = license;
            this.enginePower = enginePower;
            this.maxSpeed = maxSpeed;
            this.color = color;
            this.type = type;


        }
        public void carInfo()
        {
            Console.WriteLine(this.license + " " + this.enginePower + " " + this.maxSpeed + " " + this.color + " " + this.type);
        }
        public void drive()
        {
            Console.WriteLine(this.license + " can drive");
        }

    }

    class Plane : Transportation
    {
        private string wingSpan;
        private string loadCapacity;
        private string netWeight;
        private string flyingClass;

        public Plane(string license, string enginePower, string wingSpan, string loadCapacity, string netWeight, string flyingClass)
        {
            this.license = license;
            this.enginePower = enginePower;
            this.wingSpan = wingSpan;
            this.loadCapacity = loadCapacity;
            this.netWeight = netWeight;
            this.flyingClass = flyingClass;

        }
        public void planeInfo()
        {
            Console.WriteLine(this.license + " " + this.enginePower + " " + this.wingSpan + " " + this.loadCapacity + " " + this.netWeight + " " + this.flyingClass);
        }
        public void fly()
        {
            Console.WriteLine(this.license + " can fly");
        }
    }
    class Boat : Transportation
    {

        private string grossTonnage;

        public Boat(string license, string enginePower, string maxSpeed, string grossTonnage)
        {
            this.license = license;
            this.enginePower = enginePower;
            this.maxSpeed = maxSpeed;
            this.grossTonnage = grossTonnage;
        }
        public void boatInfo()
        {
            Console.WriteLine(this.license + " " + this.enginePower + " " + this.maxSpeed + " " + this.grossTonnage);
        }

    }
    class CompareTrans
    {
        private string trans1;
        private string trans2;
        public CompareTrans(string trans1, string trans2)
        {
            this.trans1 = trans1;
            this.trans2 = trans2;
        }
        public void printResult()
        {
            if (trans1 == trans2)
                Console.WriteLine(this.trans1 + " and " + this.trans2 + " is the same car");
            else
                Console.WriteLine(this.trans1 + " and " + this.trans2 + " are not the same cars");
        }
    }

}
