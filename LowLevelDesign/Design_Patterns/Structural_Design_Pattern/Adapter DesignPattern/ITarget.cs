namespace LowLevelDesign.Design_Patterns.Structural_Design_Pattern.Adapter_DesignPattern
{
    // Target interface
    interface ITarget
    {
        void Request();
    }

    // Adaptee class
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee's specific request");
        }
    }

    // Adapter class
    class Adapter : ITarget
    {
        private Adaptee _adaptee = new Adaptee();

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

    // Client class
    class Client
    {
        static void Main()
        {
            ITarget target = new Adapter();
            target.Request();
        }
    }

}
