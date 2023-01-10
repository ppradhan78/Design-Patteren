using BuilderDesignPattern.Example;
using Newtonsoft.Json;
using System;
//using Newtonsoft.Json;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //MealBuilder mealBuilder = new MealBuilder();

            //Meal vegMeal = mealBuilder.prepareVegMeal();
            //Console.WriteLine("Veg Meal");
            //vegMeal.showItems();
            //Console.WriteLine("Total Cost: " + vegMeal.getCost());

            //Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
            //Console.WriteLine("\n\nNon-Veg Meal");
            //nonVegMeal.showItems();
            //Console.WriteLine("Total Cost: " + nonVegMeal.getCost());

            Console.WriteLine("-------------------------------List Of Toys--------------------------------------------");
            var toyACreator = new PatientBuilder(new PatentInfoBuilder());
            toyACreator.CreatePatent();
           var output= toyACreator.GetPatentDetails();

            Console.ReadKey();
        }
    }

}
