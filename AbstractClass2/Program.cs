using System;

namespace AbstractClass2
{
    abstract class Animal
    {
        //abstract method
        public abstract void makeSound();
    }

     class Crocodile : Animal
    {
        //abstract method
        public override void makeSound()
        { }
    }


    //inheriting from abstract class 
    class Dog : Animal
    {
        //provide implementation of abstract method 
        public override void makeSound()
        {
            Console.WriteLine("Bark Bark");
        }

        internal void makeAction()
        {
            throw new NotImplementedException();
        }
    }

    class BullDog : Dog
    {
        //provide implementation of abstract method 
        public override void makeSound()
        {
            Console.WriteLine("Bulldog Bark Bark");
        }

         void makeAction()
        {
            throw new NotImplementedException();
        }
    }


    class Cat : Animal
    {
        //provide implementation of abstract method 
        public override void makeSound()
        {
            Console.WriteLine("Bite");
        }
    }

    class Lion : Animal
    {
        //provide implementation of abstract method 
        public override void makeSound()
        {
            Console.WriteLine("Roar Roar");
        }
    }
    class Program
    {
       static void Main(string[] args)
        {
            //create an abstract of Dog class
            Dog dog = new Dog();
            dog.makeSound();

            Cat redCat = new Cat();
            redCat.makeSound();

            Lion lion = new Lion();
            lion.makeSound();
            BullDog bulldog = new BullDog();
            bulldog.makeAction();

            Console.ReadLine();
        }
    }

  }