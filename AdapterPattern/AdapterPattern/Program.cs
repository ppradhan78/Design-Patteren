using AdapterPattern.Adeptor;
using AdapterPattern.DTO;
using System;
using System.Collections.Generic;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer = new CustomerAdeptor();
            IEnumerable<CustomerDTO> data = customer.GetCustomers();
            foreach (var item in data)
            {
                Console.WriteLine(item.FullName);
            }
        }
    }
            #region Comment code
            //class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        Crow sparrow = new Crow();
            //        IToyDuck toyDuck = new PlasticToyDuck();

            //        // Wrap a bird in a birdAdapter so that it  behaves like toy duck
            //        IToyDuck birdAdapter = new BirdAdapter(sparrow);
            //        Console.WriteLine("Crow...");
            //        sparrow.fly();
            //        sparrow.makeSound();
            //        Console.WriteLine("ToyDuck...");
            //        toyDuck.squeak();
            //        // toy duck behaving like a bird 
            //        Console.WriteLine("BirdAdapter...");
            //        birdAdapter.squeak();

            //        Console.ReadLine();
            //    }
            //}
            //interface IBird
            //{
            //    // birds implement Bird interface that allows them to fly and make sounds adaptee interface
            //    public void fly();
            //    public void makeSound();
            //}
            //class Crow : IBird
            //{
            //    // concrete implementation of bird
            //    public void fly()
            //    {
            //        Console.WriteLine("Flying");
            //    }
            //    public void makeSound()
            //    {
            //        Console.WriteLine("Ka Ka..");
            //    }
            //}
            //interface IToyDuck
            //{
            //    // target interface toyducks dont fly they just make squeaking sound
            //    public void squeak();
            //}
            //class PlasticToyDuck : IToyDuck
            //{
            //    public void squeak()
            //    {
            //        Console.WriteLine("Squeak");
            //    }
            //}
            //class BirdAdapter : IToyDuck
            //{
            //    // You need to implement the interface your client expects to use.
            //    IBird bird;
            //    public BirdAdapter(IBird bird)
            //    {
            //        // we need reference to the object we  are adapting
            //        this.bird = bird;
            //    }

            //    public void squeak()
            //    {
            //        // translate the methods appropriately
            //        bird.makeSound();
            //    }
            //}

            #endregion
        }
