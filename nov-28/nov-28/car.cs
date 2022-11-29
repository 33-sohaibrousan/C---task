using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace nov_27
{
    class car
    {
        public string car_make { get; set; }
        public string type { get; set; }
        public int price { get; set; }
        public int year { get; set; }
        public int model { get; set; }
        public string color { get; set; }
        public int pallet_NO { get; set; }
        string startEngine { get; set; }
        public int litter { get; set; }

        public car() { }
        public car(string car_make, string type, int price, int year, string color, int pallet_NO, int model, string startEngine, int litter)

        {
            this.car_make = car_make;
            this.type = type;
            this.price = price;
            this.year = year;
            this.color = color;
            this.model = model;
            this.pallet_NO = pallet_NO;
            this.startEngine = startEngine;
            this.litter = litter;






        }
        public void engine()
        {
            if (startEngine == "start")
            {
                Console.WriteLine("the engine is on");
            }
            else { Console.WriteLine("the engine is off"); }
        }

        public void test()
        {
            Console.WriteLine($"car  made in  : {car_make}\n" + $"the type is : {type}\n" +
                     $"the price is : {price}\n" + $"the year is : {year}\n"
                    + $"the color is : {color}\n" + $"the pallet no is : {pallet_NO}\n"
                    + $"the model is : {model}\n");
        }

        public void litterL()
        {
            Console.WriteLine(litter * 18+" litter");
        }


        class Mycar : car
        {
            public Mycar(string make_car, int year, string type, string color, int price, int model, int pallet_NO, int litter) //: base(make_car, year, type, color, price, model, pallet_NO,litter)
            {
                this.car_make = car_make;
                this.type = type;
                this.price = price;
                this.year = year;
                this.color = color;
                this.model = model;
                this.pallet_NO = pallet_NO;
                this.startEngine = startEngine;
                this.litter = litter;


            }


        }


    }
    public class program
    {
        static void Main(string[] args)
        {
            car test1 = new car("Italy", "ferrari", 20000, 2022, "red", 0790552430, 2022, "start", 20);
            test1.test();
            test1.engine();
            test1.litterL();

        }
    }
}