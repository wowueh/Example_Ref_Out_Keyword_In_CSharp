using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class AbstractClass
    {
        public abstract void AbstractMethod();
        public void NormalMethod() { }
        public virtual void VirtualMethod()
        {

        }
    }
    class Kethua:AbstractClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("AbstractMethod da duoc overide!");
        }
        
    }
    class Program
    {
        public static void SwapVar<T>(ref T var1, ref T var2)
        {
            T temp;
            temp = var1;
            var1 = var2;
            var2 = temp;
        }
        private static void OutExample(out int var1, out int var2)
        {
            int a = 20;
            int b = 30;
            var1 = a;
            var2 = b;
        }
        static void Main(string[] args)
        {
            //Swap var int
            int a = 5;
            int b = 10;
            Console.WriteLine("Truoc khi swap: a={0},b={1}",a,b);
            SwapVar<int>(ref a, ref b);
            Console.WriteLine("Sau khi swap: a={0},b={1}", a, b);
            Console.ReadKey();

            //Swap var string
            string c = "Thu 2";
            string d = "Thu 3";
            Console.WriteLine("Truoc khi swap: a={0},b={1}", c, d);
            SwapVar<string>(ref c, ref d);
            Console.WriteLine("Sau khi swap: a={0},b={1}", c, d);
            Console.ReadKey();

            //Test out keyword
            int out1, out2;
            OutExample(out out1, out out2);
            Console.WriteLine("Gia tri cua out1 = {0}, out2 = {1}",out1, out2);
            Console.ReadKey();

            //Test Abstract Class
            Kethua kt = new Kethua();
            kt.AbstractMethod();
            Console.ReadKey();

            //Test object
            
        }
    }
}
