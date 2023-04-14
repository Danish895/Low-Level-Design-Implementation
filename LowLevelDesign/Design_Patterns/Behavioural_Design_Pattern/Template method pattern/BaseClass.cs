namespace LowLevelDesign.Design_Patterns.Behavioural_Design_Pattern.Template_method_pattern
{
    

    // Abstract class
    abstract class BaseClass
    {
        // Template method
        public void TemplateMethod()
        {
            Console.WriteLine("Executing template method...");

            DoStepOne();
            DoStepTwo();
            DoStepThree();
        }

        // Abstract methods to be implemented by subclasses
        protected abstract void DoStepOne();
        protected abstract void DoStepTwo();

        // Hook method (optional)
        protected virtual void DoStepThree()
        {
            Console.WriteLine("Default implementation of step three.");
        }
    }

    // Concrete class
    class ConcreteClass : BaseClass
    {
        protected override void DoStepOne()
        {
            Console.WriteLine("Doing step one in concrete class.");
        }

        protected override void DoStepTwo()
        {
            Console.WriteLine("Doing step two in concrete class.");
        }

        protected override void DoStepThree()
        {
            Console.WriteLine("Doing step three in concrete class.");
        }
    }

    // Client code
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass template = new ConcreteClass();
            template.TemplateMethod();

            Console.ReadKey();
        }
    }

}
