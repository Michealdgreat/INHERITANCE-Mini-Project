using System;

namespace InheritanceMiniProject
{
    public class ExcavatorModel : InventoryItemModel, IRentable
    {
        public void Dig()
        {
            Console.WriteLine("I am Digging");
        }

        public void Rent()
        {
            Quantityinstock -= 1;
            Console.WriteLine("This excavator has rented!.  ");
        }

        public void ReturnRental()
        {
            Quantityinstock +=1;
            Console.WriteLine("You can rent now");
        }
    }
}
