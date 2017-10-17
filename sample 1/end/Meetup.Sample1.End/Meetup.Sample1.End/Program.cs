using System;
using Meetup.Sample1.End.Engine;

namespace Meetup.Sample1.End
{
    class Program
    {
        static void Main(string[] args)
        {
            var gasCar = new Car(new GasEngine());
            gasCar.Start();
            var electricCar = new Car(new ElectiricEngine());
            electricCar.Start();
            var hybridCar = new Car(new HybridEngine());
            hybridCar.Start();
        }
    }
}
