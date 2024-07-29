using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class building
    {
        public string BuildingType;
        public string Capacity;
        public string Dimension;
        public string area;
        public DateTime DOC;
        //msil file is created after compilation CLR (common lang runtime) convert MSIL file to binary
        public building(string BuildingType, string capacity, string Dimension, string area)
        {
            this.BuildingType = BuildingType;
            this.Capacity = Capacity;
            this.Dimension = Dimension;
            this.area = area;
            //this.DOC = DOC;
            
        }
        public void Display()
        {
            Console.WriteLine("Building Type: " + BuildingType);
            Console.WriteLine("Capacity: " + Capacity);
            Console.WriteLine("Dimension: " + Dimension);

            if (BuildingType.ToLower() == "flat")
            {
                Console.WriteLine("Floor Number: " + area);
            }
            else if (BuildingType.ToLower() == "villa")
            {
                Console.WriteLine("Land Dimension: " + area);
            }

            Console.WriteLine("Date of Completion: " + DOC);

        }
        public static void Main(string[] args)
        {
          
            building flat = new building("Flat", "3BHK", "1200 sq ft", "5");
            Console.WriteLine("Flat Details:");
            flat.Display();

            building villa = new building("Villa", "4BHK", "3000 sq ft", "40X60");
            Console.WriteLine("\nVilla Details:");
            villa.Display();

        }

    }
}
