//using Newtonsoft.Json;
//using System;
////using Newtonsoft.Json;

//namespace BuilderDesignPattern
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            User builder = new UserBuilder().SetName("ppradha7").SetAge(34).SetPhone("9948777325").SetAddress(new Address("12345", "Manin")).BuildUser();
//            Console.ReadKey();
//        }
//    }

//    class Address
//    {
//        public string Zip { get; set; }
//        public string Street { get; set; }
//        public Address(string zip, string street)
//        {
//            this.Zip = zip;
//            this.Street = street;
//        }
//    }
//    class User
//    {
//        private string Name;
//        private int Age;
//        private string Phone;
//        private Address Address;
//        public User(string name, int age, string phone, Address address)
//        {
//            this.Name = name;
//            this.Age = age;
//            this.Phone = phone;
//            this.Address = address;

//        }
//    }
//    class UserBuilder
//    {
//        private string Name;
//        private int Age;
//        private string Phone;
//        private Address Address;
//        private User User { get; set; }
//        public UserBuilder SetName(string name)
//        {
//            this.Name = name;
//            return this;
//        }
//        public UserBuilder SetAge(int Age)
//        {
//             this.Age = Age;
//            return this;
//        }
//        public UserBuilder SetPhone(string phone)
//        {
//            this.Phone = phone;
//            return this;
//        }
//        public UserBuilder SetAddress(Address address)
//        {
//            this.Address = address;
//            return this;
//        }
//        public User BuildUser()
//        {
//            return new User(Name, Age, Phone, Address);
//        }
//    }
//}
