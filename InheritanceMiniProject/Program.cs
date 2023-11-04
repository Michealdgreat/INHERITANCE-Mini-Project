using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
           // List<InventoryItemModel> inventory= new List<InventoryItemModel>();
            List<IRentable> rentables = new List<IRentable>();
            List<Ipurchaseable> purchaseables = new List<Ipurchaseable>();


            var vehicle = new vehicleModel() { DealerFee = 25, productname = "Kia Optima" };
            var book = new bookModel() { productname = "A tale of Man", numberOfPages = 1002 };
            var escavator = new ExcavatorModel {productname = "Bulldozer", Quantityinstock=2};

            rentables.Add(vehicle);
            rentables.Add(escavator);

            purchaseables.Add(book);
            purchaseables.Add(vehicle);

            Console.Write("Do you want to rent or purchase something: (rent, purchase)");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: {item.productname}");
                    Console.WriteLine("Do you want to rent this Item: Yes/No");
                    string wanttorent = Console.ReadLine();

                    if (wanttorent.ToLower() == "Yes")
                    {
                        item.Rent();
                    }

                    Console.WriteLine($"Item: {item.productname}");
                    Console.WriteLine("Do you want to rent this Item: Yes/No");
                    string wanttorenturn = Console.ReadLine();

                    if (wanttorenturn.ToLower() == "Yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (var item in purchaseables)
                {
                    Console.WriteLine($"Item: {item.productname}");
                    Console.WriteLine("Did you want to purchase this product: (Yes/No)");
                    string wanttopurchase = Console.ReadLine();

                    if (wanttopurchase.ToLower() == "yes")
                    {
                        item.purchase();
                    }
                }
            }
            Console.WriteLine("We are done.!");
            Console.ReadLine();
        }

    }
}
