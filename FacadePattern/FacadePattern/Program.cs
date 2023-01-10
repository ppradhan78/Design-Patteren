using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelKeeper keeper = new HotelKeeper();

            keeper.getVegMenu();
            keeper.getNonVegMenu();
            keeper.getVegNonMenu();


            Console.ReadKey();
        }
    }
    public interface IHotel
    {
        public void getMenus();
    }
    public class NonVegRestaurant : IHotel
    {
        public void getMenus()
        {
            Console.WriteLine("NonVegRestaurant Menu");
        }
    }
    public class VegRestaurant : IHotel
    {

        public void getMenus()
        {
            Console.WriteLine("VegRestaurant Menu");
        }
    }
    public class VegNonBothRestaurant : IHotel
    {
        public void getMenus()
        {
            Console.WriteLine("Both Veg and Non-Veg Restaurant Menu");
        }
    }
    public class HotelKeeper
    {
        private NonVegRestaurant nonVegRestaurant;
        private VegRestaurant vegRestaurant;
        private VegNonBothRestaurant vegNonBothRestaurant;
        public HotelKeeper()
        {
            nonVegRestaurant = new NonVegRestaurant();
            vegRestaurant = new VegRestaurant();
            vegNonBothRestaurant = new VegNonBothRestaurant();
        }
        public void getVegMenu()
        {
            vegRestaurant.getMenus();
        }

        public void getNonVegMenu()
        {
            nonVegRestaurant.getMenus();
        }

        public void getVegNonMenu()
        {
            vegNonBothRestaurant.getMenus();
        }
    }

}
