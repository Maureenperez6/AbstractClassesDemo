using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {

        public string Year { get; set; } = "0";
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model";

        public abstract void Drive();
        public abstract void Start();
        public abstract void Stop();

         
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"vehicle driving virtually");
        }
        

        
        
       
    }
}


