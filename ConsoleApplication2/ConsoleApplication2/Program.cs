//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    class Class
//    {
//        string _firstName;
//        string _lastName;
//        //creating a constractor
//        public Class(string FirstName, string LastName)
//        {
//            //_firstName = FirstName;
//            //_lastName = LastName;
//            this._firstName = FirstName;
//            this._lastName = LastName;
//        }
//        //creating a method
//        public void PrintFulname()
//        {
//            Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
//            Console.ReadLine();
//        }
//        //creating a destractor
//        ~Class()
//        {
//            //ckean up code 
//        }

//    }
//    //calling the class nside the main method
//    class Program
//    {
//        public static void Main()
//        {
//            Class c1 = new Class("Taleb", "Mosyri");
//            c1.PrintFulname();
//        }
//    }
//}

//using System;
//class Circle
//{
//    float _PI = 3.141F;
//    int _Radius;
//    public Circle(int Radius)
//    {
//        this._Radius = Radius;
//    }
//    public float CalculateArea()
//    {
//        return this._PI * this._Radius;
//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        Circle c1 = new Circle(5);
//        float Area = c1.CalculateArea();
//        Console.WriteLine("Area = {0}", Area);


//        Circle c2 = new Circle(6);
//        float Area1 = c2.CalculateArea();
//        Console.WriteLine("Area1 = {0}", Area1);


//        Console.ReadLine();
//    }
//}

//using System;

//public class Employee
//{
//      public string FirstName;
//      public string LastName;
//      public string Email;

//    public void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " +LastName);
//    }
//}

//public class FullTimeEmployee : Employee
//{
//    public float YearlySalary;
//}
//public class PartTimeEmployee : Employee
//{
//    float HourlyRate;
//}

//public class Program
//{
//    public static void Main()
//    {
//        FullTimeEmployee FTE = new FullTimeEmployee();
//        FTE.FirstName = "Taleb";
//        FTE.LastName = "Mosyri";
//        FTE.YearlySalary = 5000;
//        FTE.PrintFullName();
//        Console.ReadLine();
//    }
//}

//using System;
//public class BaseClass
//{
//    //overriding methd
//    public virtual void Print()
//    {
//        Console.WriteLine("I am a Base Class Prnt Method");
//    }
//}

//public class DerivedClass : BaseClass
//{
//    //hiding method
//    public new Print()
//    {
//        Console.WriteLine("I am a Derived Class Print Method");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        BaseClass b = new BaseClass();
//        b.Print();
//    }
//}

using System;
/// <summary>
/// overloading a method
/// </summary>
public class Program
{
    public static void Main()
    {
        
    }
    public static void Add(int FN, int SN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }
    public static void Add(int FN, int SN, int TN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }
}
