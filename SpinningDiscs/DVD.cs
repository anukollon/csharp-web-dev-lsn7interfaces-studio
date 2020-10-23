using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(string name, int capacity, string typeOfData, string discType):base(name, capacity, typeOfData,discType)
        {
            MinSpinSpeed = 570;
            MaxSpinSpeed = 1600;
        }

        public void SpinDisc()
        {
            Console.WriteLine("A " + DiscType + " spins at a rate of " + MinSpinSpeed + " - " + MaxSpinSpeed + " rpm.\n");
        }


    }
}
