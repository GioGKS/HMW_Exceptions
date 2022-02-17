using System;
namespace HMW_Exceptions
{
    public class Garage : IGarage
    {
        public Car[] Cars { get; set; }
        public string[] CarTypes { get; set; }
        public int counter { get; set; }


        public Garage(string[] carTypes)
        {
            CarTypes = carTypes;
        }


        public void AddCar(Car car1)
        {
            if (car1 == null)
                throw new CarNullException("Car Does not exist.");
            if (car1.TotalLost)
                throw new WeDoNotFixTotalLostException("We Cant fix this Car");
            if (!car1.NeedsRepair)
                throw new RepairMismatchException("Car Dont need repair..");
            if (Array.Exists(Cars, x => x == car1) == true)
                throw new CarAlreadyHereException("Car Already Here");
            if (Array.Exists(CarTypes, x => x == car1.Brand) == false)
                throw new WrongGarageException("You Need Another Garage");
            Cars[counter++] = car1;
        }

        public void TakeOutCar(Car car2)
        {
            if (car2 == null)
                throw new CarNullException("Car Does not exist.");
            if (Array.Exists(Cars, x => x == car2) == false)
                throw new CarNotInGarageException("Car Not Here");
            if (car2.NeedsRepair)
                throw new CarNotReadyException("Car still need repair..");

        }

        public void FixCar(Car car3)
        {
            if (car3 == null)
                throw new CarNullException("Car Does not exist.");
            if (Array.Exists(Cars, x => x == car3) == false)
                throw new CarNotInGarageException("Car Not Here");
            if (!car3.NeedsRepair)
                throw new RepairMismatchException("Car dont need repair..");


        }
    }
}
