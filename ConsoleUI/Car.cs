using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
     public  class Car: Vehicle
    {
        public bool HasTrunk { get; set; } = true;

        public override void Drive()
        {
            Console.WriteLine("Cars Drives on 4 wheels");
        }
        public override void Start()
        {
            Console.WriteLine("Press on Break and push start button");
        }
        public override void Stop()
        {
            Console.WriteLine("Press on breaks to stop car.");
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("spacious car driving");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine();
            base.DriveVirtual();        
        }


    }
}
