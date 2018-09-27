using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
// Helen Brennan student ID:9981703
{
    class Bird
    { //Properties

        public string Name { get; set; }
        public string Species { get; set; }
        public string Sex { get; set; }
        public string Weight { get; set; }
        public int Bandnum { get; set; }

        //Constructor 

        public Bird(string name, string species, string sex, string weight, int bandnum)
        {
            Name = name;
            Species = species;
            Sex = sex;
            Weight = weight;
            Bandnum = bandnum;

            //I should put the default data in here
        }





        //public string DisplayBird

        //return "Bird name:" + Name + "Species:" + Species + "Bird sex:" + Sex + "Weight:" + Weight + "BandNumber:" + Bandnum;

    }










}       

        









        class Program
    {//Main method
        static void Main(string[] args)
        {
            //Taking user input
            Console.Write("Please update bird data");
            Console.Write("Enter Bird Name:");
            string name = Console.ReadLine();
            Console.Write("Enter Species:");
            string species = Console.ReadLine();
            Console.Write("Enter the sex:");
            string sex = Console.ReadLine();
            Console.Write("Enter the Weight of the Bird in grams");
            string weight = Console.ReadLine();
            Console.Write("Enter the Band number");
            int bandnum = int.Parse(Console.ReadLine());


            //So user can add more than bird
            Bird b1 = new Bird(name, species, sex, weight, bandnum);

            //Displaying data to user
            Console.WriteLine("Bird of Prey Data output");
            Console.Write( $"Bird Name:{b1.Name}");
            Console.Write($"Species:{b1.Species}");
            Console.Write($"Sex:{b1.Sex}");
            Console.Write($"Weight:{b1.Weight}");
            Console.Write($"Band Number:{b1.Bandnum}");








            Console.ReadKey();








        }
    }
      
    





