using System;
namespace HMW_Exceptions
{
    public class Car
    {
        public string Brand { get; set; }
        public bool TotalLost { get; set; }
        public bool NeedsRepair { get; set; }

        public Car()
        {
        }

        public Car(string brand, bool totallost, bool needsrepair)
        {
            Brand = brand;
            TotalLost = totallost;
            NeedsRepair = needsrepair;

            if(TotalLost == true && NeedsRepair == false)
            {
                Exception RepairMismatchException = new Exception("We Cant Fix Your Car");
                throw RepairMismatchException;
            }
        }

        
    }
}
