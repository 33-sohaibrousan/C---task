using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 42;
            int b = 119;
            int c = a + b;
            Console.WriteLine(c);




            //==========================================
            int myNum = 5;
            Console.WriteLine(myNum);
            double myDoubleNum = 5.99D;
            Console.WriteLine(myDoubleNum);

            char myLetter = 'D';
            Console.WriteLine(myLetter);

            bool myBool = true;
            Console.WriteLine(myBool);

            string myText = "Hello";
            Console.WriteLine(myText);

            //==========================================

            string[] viachle = { "toyota", "ferrari", "lexis", "aston martin" };
            Console.WriteLine(viachle[0]);

            //==========================================
            string firstname = "sohaib";
            string surename = " alrousan";
            string birth = " 1999";
            Console.WriteLine(firstname + surename + birth);

            //==========================================

            int[] data = { 1, 1, 2, 3,4,5,6,7,8,9 };
            Console.WriteLine(data[0]+" "+ data[1]+" "+ data[2]+" "+ data[3]+" "+ data[4]+" "+ data[5]+" "+ data[6]+" "+ data[7]+" "+ data[8]);

            //==========================================

            int[] sumdata = { 5, 6, 4 };
            Console.WriteLine(sumdata[0] + sumdata[1] + sumdata[2]);
        }
    }
}













