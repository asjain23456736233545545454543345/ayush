using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace sanjay
{
    public class overconstruct
    {
        public overconstruct()
        {
            Console.WriteLine("\n1.this is default constructor\n");
        }
        public overconstruct(string name)
        {
            Console.WriteLine("2.constructor with out parameter");
            Console.WriteLine("parameter:\nname{0}\n,name");
        }
        public overconstruct(string name, int num)
        {
            Console.WriteLine("3.constructor with one parameter");
            Console.WriteLine("parameter:\nname={0}\nnum ={1}n", name, num);
        }
        public void asg()
        {
            Console.WriteLine("this is the example of constructor overloading");
        }
    }
    public class demo
    {
        public static void main()
        {
            Console.WriteLine("enter parameter");
            string str = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            overconstruct oc1 = new overconstruct();
            overconstruct oc2 = new overconstruct(str);
            overconstruct oc3 = new overconstruct(str, num);
            oc1.asg();
            Console.ReadLine();
        }
    }
}



    
    
       
        
        
    

