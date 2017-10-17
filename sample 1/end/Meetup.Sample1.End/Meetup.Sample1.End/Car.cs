using Meetup.Sample1.End.Engine;

namespace Meetup.Sample1.End
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