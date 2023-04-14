namespace LowLevelDesign.Design_Patterns.Creational_Design_Pattern.Abstract_Factory_Pattern
{
    using System;

    public interface IAnimal
    {
        void Speak();
    }

    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }

    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }

    public interface IAnimalFactory
    {
        IAnimal CreateAnimal();
    }

    public class DogFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }

    public class CatFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }

    public interface IAnimalSoundFactory
    {
        IAnimalFactory CreateAnimalFactory();
    }

    public class AnimalSoundFactory1 : IAnimalSoundFactory
    {
        public IAnimalFactory CreateAnimalFactory()
        {
            return new DogFactory();
        }
    }

    public class AnimalSoundFactory2 : IAnimalSoundFactory
    {
        public IAnimalFactory CreateAnimalFactory()
        {
            return new CatFactory();
        }
    }

    public class Client
    {
        private IAnimalSoundFactory factory;
        private IAnimalFactory animalFactory;
        private IAnimal animal;

        public Client(IAnimalSoundFactory factory)
        {
            this.factory = factory;
            this.animalFactory = factory.CreateAnimalFactory();
            this.animal = animalFactory.CreateAnimal();
        }

        public void Run()
        {
            Console.WriteLine("Using {0}:", this.factory.GetType().Name);
            this.animal.Speak();
        }
    }

    public class Program
    {
        public static void Main()
        {
            Client client1 = new Client(new AnimalSoundFactory1());
            client1.Run();

            Client client2 = new Client(new AnimalSoundFactory2());
            client2.Run();
        }
    }

}
