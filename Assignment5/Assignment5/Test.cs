using FurnitureStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Furniture
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string FurnitureType { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public string PaymentMode {  get; set; }

        public virtual void Enter()
        {
            Console.Write("Enter Id: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Date YYYY-MM-DD: ");
            Date = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            Quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Amount: ");
            Amount = int.Parse(Console.ReadLine());
            Console.Write("Payment Mode (Credit/Debit): ");
            PaymentMode = (Console.ReadLine());
        }

        public void ShowData()
        {
            Console.Write($"Id: {Id}\nDate: {Date}");
            if (FurnitureType == null)
            {
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine($"Furniture Type: {FurnitureType}");
            }
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Total Amount: {Amount}");
            Console.WriteLine($"Payment Mode: {PaymentMode}");
        }
    }
    public class Chair: Furniture
    {
        
        public string ChairType { get; set; }
        public string purpose { get; set; }
        public string WoodType { get; set; }
        public string SteelType { get; set; }
        public string PlasticColor { get; set; }
        public double Rate { get; set; }

        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Purpose (Home/Office): ");
            purpose = Console.ReadLine();
            Console.WriteLine("Enter Chair Type (Wood/Steel/Plastic): ");
            ChairType = Console.ReadLine();
            if (ChairType.ToLower() == "wood")
            {
                Console.WriteLine("Choose wood Type (Wood/Rose): ");
                WoodType = Console.ReadLine();
            }
            else if (ChairType.ToLower() == "steel")
            {
                Console.WriteLine("Choose Steel Type (Grey steel/Green steel/Brown Steel): ");
                SteelType = Console.ReadLine();
            }
            else if (ChairType.ToLower() == "plastic")
            {
                Console.WriteLine("Choose Plastic Color (Green/Red/Blue/White): ");
                PlasticColor = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine("Enter Rate: ");
            Rate = double.Parse(Console.ReadLine());
        }
        public void ShowData()
        {
            Console.Write($"ChairType: {ChairType}\npurpose: {purpose}");
            if (ChairType == "Wood")
            {
                Console.WriteLine($"Wood Type: {WoodType}");
            }
            else if (ChairType == "Steel")
            {
                Console.WriteLine($"Steel Type: {SteelType}");
            }
            else
            {
                Console.WriteLine($"Plastic Color: {PlasticColor}");
            }
            

            Console.WriteLine($"Rate: {Rate}");
        }
    }
    public class Cot : Furniture
    {
        public string CotType{ get; set; }
        public int capacity { get; set; }
        public double Rate{ get; set; }
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Enter Cot Type (Wood/Seel): ");
            CotType = Console.ReadLine();
            Console.Write("Enter Capacity (Single/Double): ");
            capacity = int.Parse(Console.ReadLine());
            Console.Write("Enter Rate: ");
            Rate = double.Parse(Console.ReadLine());
        }
        public void ShowDate()
        {
            Console.WriteLine($"Cot Type: {CotType}\nCapacity: {capacity}\nRate: {Rate}");
        }
    }

    public class Test
    {
         static void Main()
        {
            string FurnitureType;
            Console.WriteLine("Enter Furniture Type(Chair/Cot): ");
            FurnitureType = Console.ReadLine();

            Furniture fur;
            if ( FurnitureType == "Chair")
            {
                fur = new Chair();
            }
            else if(FurnitureType == "Cot")
            {
                fur = new Cot();
            }
            else
            {
                Console.WriteLine("Invalid Furniture Type!");
                return;
            }
            fur.Enter();
            fur.ShowData();

        }
    }
}
