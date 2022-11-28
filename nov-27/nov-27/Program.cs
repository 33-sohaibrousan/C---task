using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nov_27
{
    class Class1
    {
        private int age;
        private string gender;
        private string name;
        private string email;
        private int ID;
        private string phone;

        public Class1(int age, string gender, string name, string email, int ID, string phone)
        {

            this.name = name;
            this.email = email;
            this.ID = ID;

            if (age >= 18 && age <= 60)
            {
                this.age = age;
            }
            else
            {
               //Console.WriteLine("your age is not available");
            }


            if (gender == "male" || gender == "female")
            {
                this.gender = gender;
            }
            else
            {
                Console.WriteLine("invalid gender");
            }

            if (phone.Substring(0, 3) == "077" || phone.Substring(0, 3) == "078" || phone.Substring(0, 3) == "079")
            {
                this.phone = phone;
            }
            else
            {
               this.phone = "this number is wrong";
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your gender");
            string gender = Console.ReadLine();
            Console.WriteLine("enter your email");
            string email = Console.ReadLine();
            Console.WriteLine("enter your phone");
            string phone = Console.ReadLine();
            Console.WriteLine("enter your id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            
            Class1 info = new Class1(age, gender, name, email, id, phone);

            Console.WriteLine($"my name is : {info.name}\n"+ $"my gender is : {info.gender}\n" + $"my email is : {info.email}\n" + $"my phone number is : {info.phone}\n" + $"my id is : {info.ID}\n" + $"my age is : {info.age}\n");
        }
    }
}
