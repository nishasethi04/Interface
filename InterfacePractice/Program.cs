using System;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
           /*someclass a = new someclass();
                 a.method();//SOmeclass does not contain the definition of method() function so it is a diamond problem too*/

            //We can use this
            ISomeinterface a = new someclass();//Polymorphism
                a.method();
            //OR
            ISomeinterface1 b = new someclass();
                b.method();
            //but cannot use this
            /*Isomeotherinterface c=new someclass()
                c.method();//Call is ambigous*/



               
        }
    }

    public interface ISomeinterface
    {
        void method()
        {
            Console.WriteLine("This is interface");
        }

    }
    public interface ISomeinterface1
    {
        public void  method()
        {
            Console.WriteLine("This is interface1");
        }

    }
    public interface Isomeotherinterface:ISomeinterface,ISomeinterface1
    {

        public void method3()
        {

            Console.WriteLine("Hi");
        }
    }
    public class someclass:Isomeotherinterface
    {

    }
}
