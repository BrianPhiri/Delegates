using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);
namespace Delegates
{
    class Program
    {
        static int num = 10;
        public static int AddNum(int p) {
            num += p;
            return num;
        }
        public static int MultNum(int q) {
            num *= q;
            return num;
        }
        public static int getNum() { return num; }
        static void Main(string[] args)
        {
            //create delegate instance
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //calling the instance
            nc1(25);
            Console.WriteLine("Value is :{0} ", getNum());
            nc2(5);
            Console.WriteLine("Value is :{0} ", getNum());

            Console.ReadKey();

        }
    }
}
