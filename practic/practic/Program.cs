using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first number");
             int x =Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter your second number");
            int y = Convert.ToInt16(Console.ReadLine());
             
            if(x>y)
            {
                Console.WriteLine(y);

            }
            else
            {
                Console.WriteLine(x);
            }






            //====================================================
           
            
            Console.WriteLine("enter your  number");
            int num =Convert.ToInt16(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("{0} is a positive number.\n" , num);
            }
            else
            {
                Console.WriteLine("{0} is a negative number. \n", num);
            }
            //=========================================================

            Console.WriteLine("--------------enter three  number----------------");
           // int ascnum = Convert.ToInt16(Console.ReadLine());
            int q = 15;
            int w = 12;
            int e = 10;
            
            if (q<w && w<e) {
                Console.WriteLine(q+" "+w+" "+e);
            }
            else if(e<w && w<q){
                Console.WriteLine(e+" "+w+" "+q);
            } 
           else if (q>w && w > e)
            {
                Console.WriteLine(e + " " + w + " " + q);
            }
            else if(e>w && q>e)
            {
                Console.WriteLine(w + " " + e + " " + q);
            }


            //=============================================
            Console.WriteLine("--------------max number----------------");

            int r = 15;
            int t = 10;
            int u = 2;
            
            if(r>t && t>u && r>u ) {
                Console.WriteLine(r);
                    }
            else if(u>t && u>r && t>r){
                Console.WriteLine(u);

            }
            else if(t>r && t>u && u > r)
            {
                Console.WriteLine(u);
            }

            //---------------------------------------
            Console.WriteLine("---------------------enter the distance---------------------");
            int dis = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(dis * 0.6);


            //-----------------------------------
            Console.WriteLine("---------------------enter your time(hour)---------------------");
            Console.WriteLine("hour=");
            int hour = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("minite=");

            int minite = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(hour * 60 + minite+"minutes");


            //----------------------------------
            Console.WriteLine("---------------------enter your time(minite)---------------------");
            Console.WriteLine("minite=");
            int minite2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(minite2 / 60 +"hours"+minite2%60 +"minutes");


            //-------------------------------------------
            Console.WriteLine("---------------------and the last taske ---------------------");
            string[] cars = { "mercedes", "opeleee", "honda", "toyota" };
            Console.WriteLine(cars[0].Substring(1,4));
            Console.WriteLine(cars[1].Substring(1, 4));
            Console.WriteLine(cars[2].Substring(1, 4));
            Console.WriteLine(cars[3].Substring(1, 4));
        }
    }
}
