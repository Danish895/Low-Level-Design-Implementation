namespace LowLevelDesign.Design_Patterns.Structural_Design_Pattern.Proxy_Pattern
{
    // Subject interface
    public interface ISubject
    {
        void Request();
    }

    // RealSubject class
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject Request");
        }
    }

    // Proxy class
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public void Request()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }

            _realSubject.Request();
        }
    }

    // Client class
    class Client
    {
        static void Main()
        {
            ISubject subject = new Proxy();
            subject.Request();
        }
    }

}
