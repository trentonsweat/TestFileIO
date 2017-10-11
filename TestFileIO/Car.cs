using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestFileIO
{
    class Car
    {
        protected string make;
        protected string model;
        protected int year;
        protected double price;
        public string Make
        {
            set { make = value; }
            get { return make; }
        }
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        public int Year
        {
            set { year = value; }
            get { return year; }
        }
        public Car()
        {
            make = " ";
            model = " ";
            year = 0;
            price = 0;
        }
        public Car(string car_make, string car_model, int car_year, double car_price)
        {
            make = car_make;
            model = car_model;
            year = car_year;
            price = car_price;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine(Make + " " + Model + " " + Year + " " + Price);
        }
        public override string ToString()
        {
            return (Make + " " + Model + " " + Year + " " + Price);
        }
    }
}
