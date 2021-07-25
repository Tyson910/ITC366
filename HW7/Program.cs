using System;

namespace HW7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exe5();
        }

        private static void Exe4()
        {
            Car myCar = new Car(32000, "red");
            Car yourCar = new Car(11000);
            Car theirCar = new Car();
            Console.WriteLine("My {0} car cost {1}", myCar.color, myCar.price.ToString("c2"));
            Console.WriteLine("Your {0} car cost {1}", yourCar.color, yourCar.price.ToString("c2"));
            Console.WriteLine("Their {0} car cost {1}", theirCar.color, theirCar.price.ToString("c2"));
        }

        private static void Exe5()
        {
            const int STARTING_NUM = 201601;
            BoatLicense[] license = new BoatLicense[3];
            int x;
            for (x = 0; x < license.Length; ++x)
            {
                license[x] = new BoatLicense();
                license[x].LicenseNum = ("" + x + STARTING_NUM);
            }
            license[0].State = "WI";
            license[1].State = "MI";
            license[2].State = "MN";
            license[0].MotorSizeInHP = 30;
            license[1].MotorSizeInHP = 50;
            license[2].MotorSizeInHP = 100;
            for (x = 0; x < license.Length; x++)
                Console.WriteLine( license[x].ToString() );

        }

    }

    class BoatLicense
    {
        public string State, LicenseNum;
        public int MotorSizeInHP;
        public double price;

        public BoatLicense()
        {
            this.LicenseNum = "";
            this.State = "";
        }

        override public string ToString()
        {
            price = MotorSizeInHP <= 50 ? 25.00 : 38.00;
            if (State.Length > 0)
                return $"Boat #{this.LicenseNum} from {this.State} has a {this.MotorSizeInHP} HP motor. \n the price for the license is { this.price.ToString("C") }";
            else
                return "Undefined object attributes";
        }
    }

    class Car
    {
        public string color;
        public int price;
        public Car() 
        {
            price = 10000;
            color = "black";
        }

        public Car(int price)
        {
            this.price = price;
            this.color = "black";
        }

        public Car(int price, string color)
        {
            this.price = price;
            this.color = color;
        }
    }


}
