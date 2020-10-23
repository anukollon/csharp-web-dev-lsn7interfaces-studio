using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD cd = new CD("Jingle Bells", 700, "Audio", "CD");
            DVD dvd = new DVD("The Lion King [DVD]", 4700, "Audio/Video", "DVD");

            //Load Disc Info
            cd.DiscInfo();
            dvd.DiscInfo();

            cd.SpinDisc();
            dvd.SpinDisc();

            //Test for writeData method
            cd.WriteData(200);
            cd.WriteData(800);
        }
    }
}
