using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
            foreach (int i in ARR) { Console.WriteLine(i ); };
            foreach (string a in arr2) { Console.WriteLine(a ); };
            foreach (string c in arr3) { Console.WriteLine(c ); };


            //=====================================


            Console.WriteLine("================task-2==============");

            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine("the index of " + Array.IndexOf(fruits, "Tomato"));
            Console.WriteLine("the index of " + Array.IndexOf(fruits, "Banana"));



            //========================================
            Console.WriteLine("================Food / sport / monie==============");
            string[] food = { "mansaf", "makmora", "kabsa", "lazania", "dwaly" };
            foreach(string f in food) { Console.WriteLine(f); };
            Console.WriteLine("================Food / sport / monie==============");

            string[] sport = { "formula-1", "football", "boxing" };
            for(int s = 0 ; s < sport.Length ; s++) {
                Console.WriteLine(sport[s]);
            }
            Console.WriteLine("================Food / sport / monie==============");

            string[] movie = { "legend 100", "rush", "senna", "castle in sky" };
            foreach (string m in movie) {
                Console.WriteLine(m);
            };

            //======================================
            Console.WriteLine("================Sum==============");

            Console.WriteLine("Enter three whole numbers:");
            int result = 0;
            string[] str = Console.ReadLine().Split(',');
            for (int d = 0; d < str.Length; d++) 
            {
                result += Convert.ToInt32(str[d]);
            }
            Console.WriteLine(result);
            
            //==================================
            Console.WriteLine("================1-100==============");

            

            int sum = 0;
            for (int n = 0; n <= 100; n++)
            {
                if (n %2==1) {
                    Console.WriteLine(n);
                    sum = sum + n;
                }

            }
            Console.WriteLine(sum);
            


            //=========================================
            Console.WriteLine("================   *    ==============");
         
            for(int l = 1; l <= 5; l++)
            {
                for (int space =5-l; space > 0; space--)
                {
                    Console.Write(" ");
                }
                //Console.WriteLine("\n");
                for (int j = 1; j <= l; j++)
                {
                    Console.Write("* ");

                   
                }
                Console.WriteLine();
            }
            //--------------------------------
            Console.WriteLine("================   5    ==============");
            int k = 1;
            for (int l = 1; l <= 4; l++)
            {
                
                for (int space =4 - l; space > 0; space--)
                {
                    Console.Write(" ");
                }
                //Console.WriteLine("\n");
                for (int j = 1; j <=l; j++)
                {
                    Console.Write((k++)+" ");
                    


                }
                Console.WriteLine();
                ;

            }
        }
    }
}
