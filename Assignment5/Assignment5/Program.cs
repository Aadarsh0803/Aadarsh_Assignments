using System;

namespace FurnitureStore
{
    // Base class
    public class Furniture
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string FurnitureType { get; set; }
        public int Qty { get; set; }
        public decimal TotalAmt { get; set; }
        public string PaymentMode { get; set; } 

        public virtual void GetData()
        {
            Console.Write("Enter Order ID: ");
            OrderId = int.Parse(Console.ReadLine());

            Console.Write("Enter Order Date (yyyy-mm-dd): ");
            OrderDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            Qty = int.Parse(Console.ReadLine());

            Console.Write("Enter Total Amount: ");
            TotalAmt = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Payment Mode (credit/debit): ");
            PaymentMode = Console.ReadLine();
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Order Date: {OrderDate.ToShortDateString()}");
            if (FurnitureType == null)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Furniture Type: {FurnitureType}");
            }
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Total Amount: {TotalAmt}");
            Console.WriteLine($"Payment Mode: {PaymentMode}");
        }
    }

    // Derived class for Chair
    public class Chair : Furniture
    {
        public string ChairType { get; set; } 
        public string Purpose { get; set; } 
        public string WoodType { get; set; } 
        public string SteelType { get; set; }
        public string PlasticColor { get; set; } 
        public decimal Rate { get; set; }

        public override void GetData()
        {
            base.GetData();

            Console.Write("Enter Chair Type (Wood/Steel/Plastic): ");
            ChairType = Console.ReadLine();

            Console.Write("Enter Purpose (Home/Office): ");
            Purpose = Console.ReadLine();

            if (ChairType == "Wood")
            {
                Console.Write("Enter Wood Type (Teak/Rose): ");
                WoodType = Console.ReadLine();
            }
            else if (ChairType == "Steel")
            {
                Console.Write("Enter Steel Type (Gray/Green/Brown): ");
                SteelType = Console.ReadLine();
            }
            else if (ChairType == "Plastic")
            {
                Console.Write("Enter Plastic Color (Green/Red/Blue/White): ");
                PlasticColor = Console.ReadLine();
            }

            Console.Write("Enter Rate: ");
            Rate = decimal.Parse(Console.ReadLine());
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Chair Type: {ChairType}");
            Console.WriteLine($"Purpose: {Purpose}");

            if (ChairType == "Wood")
            {
                Console.WriteLine($"Wood Type: {WoodType}");
            }
            else if (ChairType == "Steel")
            {
                Console.WriteLine($"Steel Type: {SteelType}");
            }
            else if (ChairType == "Plastic")
            {
                Console.WriteLine($"Plastic Color: {PlasticColor}");
            }

            Console.WriteLine($"Rate: {Rate}");
        }
    }

    // Derived class for Cot
    public class Cot : Furniture
    {
        public string CotType { get; set; } 
        public string WoodType { get; set; }
        public string SteelType { get; set; } 
        public string Capacity { get; set; } 
        public decimal Rate { get; set; }

        public override void GetData()
        {
            base.GetData();

            Console.Write("Enter Cot Type (Wood/Steel): ");
            CotType = Console.ReadLine();

            if (CotType == "Wood")
            {
                Console.Write("Enter Wood Type (Teak/Rose): ");
                WoodType = Console.ReadLine();
            }
            else if (CotType == "Steel")
            {
                Console.Write("Enter Steel Type (Gray/Green/Brown): ");
                SteelType = Console.ReadLine();
            }

            Console.Write("Enter Capacity (Single/Double): ");
            Capacity = Console.ReadLine();

            Console.Write("Enter Rate: ");
            Rate = decimal.Parse(Console.ReadLine());
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Cot Type: {CotType}");

            if (CotType == "Wood")
            {
                Console.WriteLine($"Wood Type: {WoodType}");
            }
            else if (CotType == "Steel")
            {
                Console.WriteLine($"Steel Type: {SteelType}");
            }

            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Rate: {Rate}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Furniture Type (Chair/Cot): ");
            string furnitureType = Console.ReadLine();

            Furniture furniture;
            if (furnitureType == "Chair")
            {
                furniture = new Chair();
            }
            else if (furnitureType == "Cot")
            {
                furniture = new Cot();
            }
            else
            {
                Console.WriteLine("Invalid Furniture Type!");
                return;
            }

            furniture.GetData();
            furniture.ShowData();
        }
    }
}
