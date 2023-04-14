namespace LowLevelDesign.Design_Patterns.Creational_Design_Pattern.Factory_Method_Pattern
{
    public abstract class Animal
    {
        public abstract string Speak();
    }

    public class Dog : Animal
    {
        public override string Speak()
        {
            return "Woof!";
        }
    }

    public class Cat : Animal
    {
        public override string Speak()
        {
            return "Meow!";
        }
    }

    public abstract class AnimalFactory
    {
        public abstract Animal CreateAnimal();
    }

    public class DogFactory : AnimalFactory
    {
        public override Animal CreateAnimal()
        {
            return new Dog();
        }
    }

    public class CatFactory : AnimalFactory
    {
        public override Animal CreateAnimal()
        {
            return new Cat();
        }
    }

    public class Program
    {
        public static void Main()
        {
            AnimalFactory factory;
            Animal animal;

            // Create a dog using the DogFactory
            factory = new DogFactory();
            animal = factory.CreateAnimal();
            Console.WriteLine(animal.Speak());

            // Create a cat using the CatFactory
            factory = new CatFactory();
            animal = factory.CreateAnimal();
            Console.WriteLine(animal.Speak());
        }
    }

}
