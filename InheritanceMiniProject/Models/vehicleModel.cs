using System;

namespace InheritanceMiniProject
{
    public class vehicleModel : InventoryItemModel, Ipurchaseable, IRentable
    {
        public decimal DealerFee { get; set; }

        public void purchase()
        {
            Quantityinstock -= 1;
            Console.WriteLine("This vehicle has been purchased.");
        }

        public void Rent()
        {
            Quantityinstock -= 1;
            Console.WriteLine("This vehicle has been rented");
        }

        public void ReturnRental()
        {
            Quantityinstock += 1;
            Console.WriteLine("Rental has been returned.");
        }
    }
}
