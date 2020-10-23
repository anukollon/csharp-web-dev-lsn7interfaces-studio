using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD cd = new CD("Jingle Bells", 700, "Audio", "CD");
            Dictionary<String, string> dictionary1 = new Dictionary<string, string>();
            dictionary1.Add("Track 1", "Believer");
            dictionary1.Add("Track 2", "Thunder");
            dictionary1.Add("Track 3", "Sugar");
            cd.Contents = dictionary1;
            
            DVD dvd = new DVD("The Lion King [DVD]", 4700, "Audio/Video", "DVD");
            Dictionary<String, string> dictionary2 = new Dictionary<string, string>();
            dictionary2.Add("Song1", "4.53");
            dictionary2.Add("Song2", "5.55");
            dictionary2.Add("Song3", "3.30");
            dvd.Contents = dictionary2;

             //Load Disc Info
            cd.DiscInfo();
            dvd.DiscInfo();

            cd.SpinDisc();
            dvd.SpinDisc();

            //Test for writeData method
            cd.WriteData(200);
            cd.WriteData(800);

            //readData
            cd.ReadData();
            dvd.ReadData();
        }
    }
}
