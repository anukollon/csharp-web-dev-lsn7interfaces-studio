using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get;  }
        public int Capacity { get;  }
        public string TypeOfData { get;  } 
        public string DiscType { get;  }

        public int MinSpinSpeed { get; set; }
        public int MaxSpinSpeed { get; set; }

        public int FreeCapacity { set; get; }

        public BaseDisc(string name, int capacity, string typeOfData, string discType)
        {
            Name = name;
            Capacity = capacity;
            TypeOfData = typeOfData;
            DiscType = discType;
            FreeCapacity = capacity;
        }

        public void WriteData(int dataCapacity)
        {
            Console.WriteLine("Trying to Write " + dataCapacity + "MB data to " + Name);
            bool isOkToWrite = FreeCapacity > dataCapacity;
            string status = "FAILURE";
            if (isOkToWrite)
            {
                FreeCapacity = FreeCapacity - dataCapacity;
                status = "SUCCESS";
            }
            Console.WriteLine("Data Write Status: " + status +" \n");

        }

        public void DiscInfo()
        {

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Capacity: " + Capacity +"MB");
            Console.WriteLine("Contents: " + TypeOfData);
            Console.WriteLine("Disc Type: " + DiscType);
            Console.WriteLine("\n");
        }

        //actual available capacity
        //free capacity

        // Disc Info return string(details - name...)

        //to write -- check for free capacity method -- conditional 
        // read --  
    }
}
