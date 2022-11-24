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
        static void task2()
        {
            Console.WriteLine("======== cube   =====");
            Console.Write("Input number of terms : ");
            int u, str2;
            str2 = Convert.ToInt32(Console.ReadLine());
            for (u = 1; u <= str2; u++)
            {
                Console.WriteLine("number is : {0} and cube of the {1} is:{2dd} \n", u, u, (u * u * u));
            }
        } 
        //---------------------------------------------------------------

        static void task3()
        {

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
            double days = 0;
            days = g * 365;
            return days;
            
        }

        //-----------------------------------------------------

        static void task5() 
        {

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

        static void task6(string email,string pass)
        {
            string[] email1 = { "sohaib", "alrousan" };
            string[] pass1 = { "123", "456" };
            int r = 0;
            int m;
            for(m = 0; m < email1.Length; m++)
            {
                if (email == email1[m] && pass == pass1[m])
                {
                    Console.WriteLine("passed");
                }
                else  
                {
                    r++;
                }


                if (m == r) { Console.WriteLine("faild"); }


            }
            //if (m == r) { Console.WriteLine("faild"); }





        }
        //---------------------------------------------------------
        static int power(int x,int n)
        {
            int pow = 1;
            for(int o=0; o<n; o++) {
                pow = pow * x;
            }
            return pow;
        }

        //-----------------------------------------------
        static void leap(int year)
        {
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
            
                Console.Write("Number is Prime.");
            

        }

       //------------------------------------------------------

        static void numbers()
        {
            string s = Console.ReadLine();
            Console.WriteLine(s.Length);

        }
        static void Main(string[] args)
        {

            //task 1
            //task1();

            //task2
            //task2();


            //task3
            // task3();


            //task4
            //Console.WriteLine("enter your age in year ");
            //double days = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(task4(days));


            //task5
            //task5();  


            //task6
            //task6("sohaib", "123");


            //task7
            //int x = 2;
            //int n = 3;
            //Console.WriteLine(power(x, n));


            //task8
            //leap(2004);


           //task9
          // prime();


            //task10
            numbers();
        }
    }
}
