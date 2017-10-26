using System;
using Meetup.Sample1.Start.Engine;

namespace Meetup.Sample1.Start
{
    class Program
    {
        static void Main(string[] args)
        {
            var gasCar = new Car(new GasEngine());
            gasCar.Start();
            var hybridCar = new Car(new HybridEngine());
            hybridCar.Start();
        }
    }
}
