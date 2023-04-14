namespace LowLevelDesign.Design_Patterns.Structural_Design_Pattern.Facade_Pattern
{
    

    // Subsystem classes
    class SubsystemA
    {
        public void MethodA()
        {
            Console.WriteLine("SubsystemA MethodA");
        }
    }

    class SubsystemB
    {
        public void MethodB()
        {
            Console.WriteLine("SubsystemB MethodB");
        }
    }

    class SubsystemC
    {
        public void MethodC()
        {
            Console.WriteLine("SubsystemC MethodC");
        }
    }

    // Facade class
    class Facade
    {
        private SubsystemA _subsystemA;
        private SubsystemB _subsystemB;
        private SubsystemC _subsystemC;

        public Facade()
        {
            _subsystemA = new SubsystemA();
            _subsystemB = new SubsystemB();
            _subsystemC = new SubsystemC();
        }

        public void Method()
        {
            _subsystemA.MethodA();
            _subsystemB.MethodB();
            _subsystemC.MethodC();
        }
    }

    // Client class
    class Client
    {
        static void Main()
        {
            Facade facade = new Facade();
            facade.Method();
        }
    }

}
