/*using System;

public class A//perent class, super class, Base class
{
    public string name;//datamember, variable, field, property
    public string DOB;
}
public void Run()//behaviour,subrutien, method, 
{
    Console.WriteLine("I am runing");
}
public void Go()
{
    Console.WriteLine("I am going");
}
public void Wait()
{
    Console.WriteLine("I am waiting.....");
}
public class B:A//B is subclass,child, Drive class
{
    public void test()
    {
        B b1 = new B();
        b1.test();
        Console.WriteLine("This is a test");
    }

}
class Employee
    {
        static void Main(string[] args)
        {
        B b1 = new B();
        b1.test();

        }
    }*/
/*using System;
public class A
{
    public void Click()
    {
        Console.WriteLine("This is click method");
    }
}
public class B:A
{
    public void Drow()
    {
        Console.WriteLine("This is Drow Method");
    }
}
public class C:A
{
    public void Paint()
    {
        Console.WriteLine("This is the Paint Method");
    }
}
public class Employee {
    static void Main()
    {
        B b1 = new B();
        b1.Drow();
        b1.Click();
        C c1 = new C();
        c1.Click();
        c1.Paint();
        Console.ReadLine();
    }
}*/
// Multilevel Inheritance
/*using System;

public class Super1
{
    public void Click()
    {
        Console.WriteLine("This is a Click");
    }
}
public class Super2 : Super1
{
    public void Display()
    {
        Console.WriteLine("This is a Display");

    }
}
    public class Sub : Super2
{
    public void View()
    {
        Console.WriteLine("This is a View");

    }

}
public class Emp
{
    public static void Main()
    {
        Console.WriteLine("Start");
        Sub s1 = new Sub();
        s1.Click();
        s1.Display();
        s1.View();
        Console.WriteLine("End");

    }
}*/

//inheritance addvantages: code reuseability the main addvantage of inheritance 
/*using System;
public class A
{
    public string name;
    public int age;
    public void Display()
    {
        Console.WriteLine("");
    }
    public class Employe : A
    {
        public static void Main()
        {
            A a1 = new A();
            Console.WriteLine(a1.name);
            a1.Display();
            Employe e1 = new Employe();
            e1.Display();
            Console.ReadLine();

        }
    }

}
*/
/*using System;
public class A
{
    public string Pname;
    public int Page;
    public void Display()
    {
        Console.WriteLine("this is Display method");
    }
    public class Employe : A
    {
        public string Cfname;
        public string Clname;
        public string CreateEmploye(string fname, string lname)
        {
            return "employed Created";
        }
        public static void Main()
        {
            A a1 = new A();
            Console.WriteLine(a1.Pname);
            a1.Display();


        }
    }

}*/
/*
using System;//namspace
using System.Collections;
using System.Data.SqlClient;
using TestProject.Repository;

public class A
{
    public int page = 10;
    public string pname = "Lucky";

    public bool Display()
    {
        Console.WriteLine(pname);
        return true;
    }

}
public class Employee : A
{
    public string cfname = "ravi";
    public string clname = "singh";
    public string CreateEmploye(string fullname, string age)
    {
        return "employeee created";
    }
    public static void Main()
    {
        A a1 = new A();
        Console.WriteLine(a1.Display());
        a1.CreateEmploye();

    }
}
*/


/*using System;//namspace
using System.Collections;
using System.Data.SqlClient;
using TestProject.Repository;

public class A
{
    public int page = 10;
    public string pname = "Lucky";

    public bool Display()
    {
        Console.WriteLine(pname);
        return true;
    }

}
public class Employee : A
{
    public string cfname = "ravi";
    public string clname = "singh";
    public string CreateEmploye(string fullname, string age)
    {
        return "employeee created";
    }
    public static void Main()
    {

        Employee e1 = new Employee();
        e1.CreateEmploye("raj", "verma");
        e1.Display();
    }
*/
/*
using System;
public class A
{
    public int age;
    public string Fname;
    public  void Run()
    {
        Console.WriteLine("This is the Run Method");
    }
    public  void Display()
    {
        Console.WriteLine("This is the Display Method");
    }

}
public class B:A
{
    public void View()
    {
        Console.WriteLine("This is View Method");
    }
}
public class Employee:A
{
    static void Main()
    {
        A a1 = new A();
        a1.Display();
        a1.Run();
        Employee e1 = new Employee();
        e1.Run();
        Console.WriteLine(a1.age);

    }
}*/
/*
using System;
public abstract class A
{
    public void T1(int age)
    {
        Console.WriteLine("This is t1 method");
    }
    public abstract void T2(string Fname, string Lname);

}
abstract class B : A
{
    public void test()
    {
        Console.WriteLine("This is test ");
    }
}
public class C : A
{
    public override void T2(string Fname, string Lname)
    {
    }
}
public class Employe:A
    {
        public static void Main()
        {
        }

    public override void T2(string Fname, string Lname)
    {
    }
}
*/
/*using System;
public class A
{
    public void Atest()
    {
        Console.WriteLine("This is test A");
    }
}
public class B:A
{
    public void Btest()
    {
        Console.WriteLine("This is test B");
    }
}
public class C:A,B
{
    public void Ctest()
    {
        Console.WriteLine("This is test C");
    }
}
public class Employee
{
    public static void Main()
    {
        A a1 = new A();
        a1.Atest();
        B b1 = new B();
        b1.Btest();
     
    }
}*/
// we can not create multiple parent class
/*using System;

public interface IA
{
    void t1(int i, int j);
    
 }
public interface IB
{
    void t2(int i, int j, int Z);

}
public class C:IA,IB
{
    public void Ctest()
    {
        Console.WriteLine("this is test c method");
 }

    public void t1(int i, int j)
    {
        Console.WriteLine("impliment t1");
    }

    public void t2(int i, int j, int Z)
    {
        Console.WriteLine("impliment t2");
    }
}
class Employee
{
    static void Main()
    {
        C c1 = new C();

    }
}*/
//abstract class we can declear constractore or interface class we can not declear constractor.
//what is abstract?
//what is interface?
//what is diffrence blw abstract and interface?
using System;
public interface Bank
{
    // method signature declaration
    void withdraw();
}

public class YesBank : Bank
{
    public void withdraw()
    {
        Console.WriteLine("Withdrawing cash from YesBank");
    }
}

public class NoBank : Bank
{
    public void withdraw()
    {
        Console.WriteLine("Withdrawing cash from NoBank");
    }
}

namespace Studytonight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bank b = new YesBank();
            b.withdraw();
            b = new NoBank();
            b.withdraw();
        }
    }
}
//when to used abstract class and when to used interface how you will desied?
//where you have have abstract class and interface in your project?
// can we instenciate abstract class or interface?
//Ans : we can't creacte object blc abstract and interface class don't have any body
//why we can declear constractor in absract class and why we can not declear constactor in interface class? 
//Ans:Interface:- Because an interface describes behaviour. Constructors aren't behaviour. How an object is built is an implementation detail.
//Abstract:- Because there might be a standard way you want to instantiate data in the abstract class. That way you can have classes that inherit from that class call the base constructor.


