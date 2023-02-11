using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//lab 3.6 - OOP
//Student: Bruno Rafael Ferreira Lopes

namespace lab_3._6
{
    class Car
    {
        //private fields
        private string cartype;
        private string model;
        private string color;
        private int year;
        private double weight;
        private double length;

        //proprieties
        public string Cartype
        {
            get { return cartype; }
            set { cartype = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Year
        {
            set { if (value < 2022 && value > 2019) { year = 2019; } else { year = value; } }
            get { return year; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        //constructors

        //default constructor
        public Car() { } 

        //constructor with 6 arguments
        public Car(string cartype, string model, string color, int year, double weight, double length)
        {
            Cartype = cartype;
            Model = model;
            Color = color;
            Year = year;
            Weight = weight;
            Length = length;
        }

        //method display
        public void Display()
        {
            Console.WriteLine($"Car file:\n======================\nCartype: {this.cartype}\nModel: {this.model}\nColor: {this.color}\nYear: {this.year}\nWeight: {this.weight}\nLength: {this.length}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1, c2, c3, c4; //new objects

            c1 = new Car(); //instantiation of the object c1 with the default constructor
            Console.WriteLine($"Display obj c1 from Display() Method");
            c1.Display();
            Console.WriteLine("=========================================================");
            Console.WriteLine();
            c2 = new Car();
            //getting data from the user for the obj c2
            Console.WriteLine("Enter with the data of the object c2: "); 
            Console.Write("Cartype: ");
            c2.Cartype = Console.ReadLine();
            Console.Write("Model: ");
            c2.Model = Console.ReadLine();
            Console.Write("Color: ");
            c2.Color = Console.ReadLine();
            label0:
            Console.Write("Year: ");
            try
            {
                c2.Year = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.Message +"Enter with a valid number for the year");
                goto label0;
            }
            label1:
            Console.Write("Weight: ");
            try
            {
                c2.Weight = double.Parse(Console.ReadLine());
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message + "Enter with a valid weight for the car");
                goto label1;
            }
        label2:
            Console.Write("Length: ");
            try
            {
                c2.Length = double.Parse(Console.ReadLine());
            }
            catch (Exception ex3)
            {
                Console.WriteLine(ex3.Message + "Enter with a valid length for the car");
                goto label2;
            }
            Console.WriteLine();
            Console.WriteLine("=========================================================");
            //display the data from the obj c2
            Console.WriteLine($"Display obj c2 from Display() Method");
            c2.Display();
            Console.WriteLine();
            Console.WriteLine("=========================================================");

            //create and instanciate the objs c3 and c4 using the constructor with 6 arguments
            c3 = new Car("Hyundai", "Elantra", "blue", 2009, 2000, 2.80);
            c4 = new Car("Honda", "Civic", "Grey", 2012, 2010.6, 2.78);

            //Displaying the objects c3 and c4
            Console.WriteLine($"Display obj c3 from Display() Method");
            c3.Display();
            Console.WriteLine( );
            Console.WriteLine("=========================================================");
            Console.WriteLine($"Display obj c4 from Display() Method");
            c4.Display();   







        }
    }
}
