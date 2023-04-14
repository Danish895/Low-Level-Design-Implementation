namespace LowLevelDesign.Design_Patterns.Creational_Design_Pattern.Singleton_Pattern
{
    
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance
        {
            get { return instance; }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is doing something.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Singleton.Instance.DoSomething();
        }
    }

}
