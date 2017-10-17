using System;

namespace Meetup.Sample1.End.Engine
{
    public class GasEngine:IEngine
    {
        public void Start()
        {
            Console.WriteLine("Gas Engine is started");
        }

        public void Stop()
        {
            Console.WriteLine("Gas Engine is stopped");
        }
    }
}