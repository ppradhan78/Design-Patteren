using System;
using System.Collections.Generic;

namespace ProxyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IInternet internet = new ProxyInternet();
            try
            {
                internet.connectTo("geeksforgeeks.org");
                internet.connectTo("abc.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
    public interface IInternet
    {
        void connectTo(String serverhost);
    }
    public class RealInternet : IInternet
    {
        public void connectTo(String serverhost)
        {
            Console.WriteLine("Connecting to " + serverhost);
        }
    }
    public class ProxyInternet : IInternet
    {
        private IInternet internet = new RealInternet();
        private static List<String> bannedSites;
        public ProxyInternet()
        {
            bannedSites = new List<String>();
            bannedSites.Add("abc.com");
            bannedSites.Add("def.com");
            bannedSites.Add("ijk.com");
            bannedSites.Add("lnm.com");
        }
        public void connectTo(String serverhost)
        {
            if (bannedSites.Contains(serverhost.ToLower()))
            {
                throw new Exception("Access Denied");
            }
            internet.connectTo(serverhost);
        }
    }
}
