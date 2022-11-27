using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_23
{
    internal class Program
    {
        static void task1()
        {
            Console.WriteLine("========  sum    avaragr   =====");
            string[] str = Console.ReadLine().Split(',');
            int[] num = new int[10];
            // int[] num1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            for (int n = 0; n <= 9; n++)
            {
                num[n] = Convert.ToInt32(str[n]);
            }
            for(int i = 0;i< num.Length; i++)
            {
                sum += num[i];
            }
            double avr =sum/ num.Length;
            Console.WriteLine("the sum of number is :" + sum);
            Console.WriteLine("the sum of number is :" + avr);

        }
        //----------------------------------------------------------
        static int task2()
        {
            Console.WriteLine("======== cube   =====");
            Console.Write("Input number of terms : ");
            int str2;
            str2 = Convert.ToInt32(Console.ReadLine());
            return str2 * str2 * str2;

        } 
        //---------------------------------------------------------------

        static void task3()
        {
            Console.WriteLine("==========max year============");

            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            int y;
            for(y = 0; y < years.Length; y++)
            {

                if (years[y] > 1950)
                {
                    Console.WriteLine("the max number is " + years[y]);

                }
            }






        }

        //--------------------------------------------------

        static double task4(double g)
        {
            Console.WriteLine("================days of year=============");
            double days = 0;
            days = g * 365;
            return days;
            
        }

        //-----------------------------------------------------

        static void task5() 
        {
            Console.WriteLine("===============number of leg==========");
            Console.WriteLine("Number of the first animal ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of the second animal ");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of the third animal ");
            int p = Convert.ToInt32(Console.ReadLine());

            int legs = ((c * 2) + (v * 4) + (p * 4));

            Console.WriteLine("Number of the all legs  " + " " + legs);
        }



        //-------------------------------------------------------

        static void task6()
        {
            Console.WriteLine("============email and password==========");
            Console.WriteLine("enter your email");
            string email = Console.ReadLine();
            Console.WriteLine("enter your password");
           string pass = Console.ReadLine();

            string[] email1 = { "sohaib", "alrousan","ahmad" };
            string[] pass1 = { "123", "456","789" };
            bool flag=false;
            for(int i  = 0; i < email1.Length; i++)
            {
                if (email == email1[i] && pass == pass1[i])
                {
                    flag = true;                   
                    break;
                }
                


                 }

            if (flag == true)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("failed");
            }




        }
        //---------------------------------------------------------
        static int power(int x,int n)
        {
            Console.WriteLine("=================power=============");
            int pow = 1;
            for(int o=0; o<n; o++) {
                pow = pow * x;
            }
            return pow;
        }

        //-----------------------------------------------
        static void leap(int year)
        {
            Console.WriteLine("==================leap===============");
            if(year>=1900 && year < 2024)
            {
                if (year % 4 == 0 && year % 100 != 0)
                {
                    Console.WriteLine(year+" this is a leap year ");
                }
                else
                {
                    Console.WriteLine(year + " this is a normal year");
                }
            }
        }

        //---------------------------------------------------
        static void prime()
        {
            Console.WriteLine("==============prime==============");
            Console.Write("Enter the Number to check Prime: ");
            int k, j, z = 0,flag=0;
            k = int.Parse(Console.ReadLine());

            z = k / 2;
            for(j=2; j<z; j++)
            {
                if (k % j == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            
                Console.WriteLine("Number is Prime.");
            

        }

       //------------------------------------------------------

        static void numbers()
        {
            Console.WriteLine("======================santance lenght==========");
            string s = Console.ReadLine();
            int space=0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i]==' ')
                {
                    space++;
                }
            }
            Console.WriteLine("numberb of words : "+(space+1));

        }
        static void Main(string[] args)
        {

            //task1();

            //Console.WriteLine(task2());


            //task3();


            //Console.WriteLine("enter your age in year ");
            //double days = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(task4(days));


            //task5();


            task6();
            


            //Console.WriteLine("enter your number");
            //int x =Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("enter the power of your number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(power(x, n));


            //leap(2004);


            //prime();


            //numbers();
        }
    }
}
