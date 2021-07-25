using System;

namespace HW7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exe4();
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
