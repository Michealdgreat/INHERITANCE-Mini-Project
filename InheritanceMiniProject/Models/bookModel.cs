using System;

namespace InheritanceMiniProject
{
    public class bookModel : InventoryItemModel, Ipurchaseable
    {
        public int numberOfPages { get; set; }

        public void purchase()
        {
            Quantityinstock -= 1;
            Console.WriteLine("This book has been purchased");
        }
    }
}
