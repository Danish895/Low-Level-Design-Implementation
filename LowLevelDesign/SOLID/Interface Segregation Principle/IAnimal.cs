namespace LowLevelDesign.SOLID.Interface_Segregation_Principle
{
    /*public interface IAnimal
    {
        void Eat();
        void Sleep();
        void Swim();
    }

    public class Lion : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Lion eats.");
        }

        public void Sleep()
        {
            Console.WriteLine("Lion sleeps.");
        }

        public void Swim()
        {
            Console.WriteLine("Lion swims.");
        }
    }

    public class Deer : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Deer eats.");
        }

        public void Sleep()
        {
            Console.WriteLine("Deer sleeps.");
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }

    public class AnimalHandler
    {
        public void HandleAnimal(IAnimal animal)
        {
            animal.Eat();
            animal.Sleep();
            animal.Swim();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Deer deer = new Deer();

            AnimalHandler animalHandler = new AnimalHandler();

            animalHandler.HandleAnimal(lion); // Output: Lion eats. Lion sleeps. Lion swims.
            animalHandler.HandleAnimal(deer); // Output: Deer eats. Deer sleeps. NotImplementedException thrown.
        }
    }
    */

    public interface IAnimal
    {
        void Eat();
        void Sleep();
    }

    public interface ISwimmingAnimal
    {
        void Swim();
    }

    public class Lion : IAnimal, ISwimmingAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Lion eats.");
        }

        public void Sleep()
        {
            Console.WriteLine("Lion sleeps.");
        }

        public void Swim()
        {
            Console.WriteLine("Lion swims.");
        }
    }

    public class Deer : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Deer eats.");
        }

        public void Sleep()
        {
            Console.WriteLine("Deer sleeps.");
        }
    }

    public class AnimalHandler
    {
        public void HandleAnimal(IAnimal animal)
        {
            animal.Eat();
            animal.Sleep();

            if (animal is ISwimmingAnimal)
            {
                ((ISwimmingAnimal)animal).Swim();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Deer deer = new Deer();

            AnimalHandler animalHandler = new AnimalHandler();

            animalHandler.HandleAnimal(lion); // Output: Lion eats. Lion sleeps. Lion swims.
            animalHandler.HandleAnimal(deer); // Output: Deer eats. Deer sleeps.
        }
    }


}
