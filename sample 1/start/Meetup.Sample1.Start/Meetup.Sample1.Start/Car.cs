using System.Reflection.Emit;


namespace Meetup.Sample1.Start
{
    public class Car
    {
        private readonly IEngine _engine;
        public Car(IEngine engine)
        {
            _engine = engine;
        }
        public void Start()
        {
            _engine.Start();
        }
    }
}