using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Motorcycle: Vehicle
    {
        public bool HasSideCart { get; set; } 

        public override void Drive()
        {
            Console.WriteLine("Motorcycles Drives on 2 wheels");
        }
        public override void Start()
        {
            Console.WriteLine("Kick start mototrcycle");
        }
        public override void Stop()
        {
            Console.WriteLine("Squeeze on breaks to stop motorcycle.");
        }

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving a {GetType().Name}, which is a {GetType().BaseType.Name} in an abstract method");

        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"I'm driving my {GetType().Name} virtually"); 
        }
        

    }
}

