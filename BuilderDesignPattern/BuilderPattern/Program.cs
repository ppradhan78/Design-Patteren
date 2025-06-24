// See https://aka.ms/new-console-template for more information
using BuilderPattern;

Console.WriteLine("Hello, World!");
var userProfileBuilder = new ConcreteVenderProfileBuilder();

userProfileBuilder.SetBasicInfo("John", "Doe", "john.doe@example.com");
userProfileBuilder.SetAddress("123 Main St", "Springfield", "IL", "12345");
userProfileBuilder.SetPreferences(true, "Dark");

var userProfile = userProfileBuilder.GetUserProfile();
userProfile.DisplayProfile();

Console.ReadKey();
