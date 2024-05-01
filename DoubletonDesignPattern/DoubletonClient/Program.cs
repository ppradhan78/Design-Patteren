// See https://aka.ms/new-console-template for more information
using DoubletonDesignPattern;

Console.WriteLine("Hello, World!");

//var obj= Doubleton.getInstance();
//Console.WriteLine(Doubleton.count);

SealedDoubleton ob1 = SealedDoubleton.GetInstance();
SealedDoubleton ob2 = SealedDoubleton.GetInstance();
SealedDoubleton ob3 = SealedDoubleton.GetInstance();
SealedDoubleton ob4 = SealedDoubleton.GetInstance();



Console.WriteLine("Obj1 and Obj2 are Equal: " + ob1.Equals(ob2));
Console.WriteLine("Obj2 and Obj3 are Equal: " + ob2.Equals(ob3));
Console.WriteLine("Obj3 and Obj4 are Equal: " + ob3.Equals(ob4));

Console.ReadKey();
Console.ReadKey();
