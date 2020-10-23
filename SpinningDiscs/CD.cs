using System;
namespace SpinningDiscs
{
    public class CD:BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public CD(string name, int capacity, string typeOfData, string discType) : base(name, capacity, typeOfData, discType)
        {
            MinSpinSpeed = 200;
            MaxSpinSpeed = 500;

        }
        public void SpinDisc()
        {
            Console.WriteLine("A " + DiscType + " spins at a rate of " + MinSpinSpeed + " - " + MaxSpinSpeed + " rpm.\n");
        }
    }
}
