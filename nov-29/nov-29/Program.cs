using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_29
{
    class Employee
    {
        string name { get; set; }
        int employee_id { get; set; }
        int birth { get; set; }
        public DateTime date_of_birth { get; set; }
        public Employee() { }
        public Employee(string name, int employee_id, int birth,int day,int month,int year)
        {
            this.name = name;
            //this.birth_of_date = birth_of_date;
            this.employee_id = employee_id;
            this.birth = birth;
            date_of_birth = new DateTime(year, month, day);
        }

        //public virtual void Age()
        //{
        //   // Console.WriteLine("the age of employee is : ");
        //    Console.WriteLine($"the age of employee is :  {2022 - birth}\n\n\n");
        //}
        public void age()
        {
            DateTime now = DateTime.Now; TimeSpan value = now.Subtract(date_of_birth);

            Console.WriteLine((int)value.TotalDays / 365);

        }
        public virtual void print() { Console.WriteLine(name + " " + employee_id + " " + date_of_birth); }

        class manager : Employee
        {
            public manager(string name, int employee_id, int birth,int day,int month,int year) : base(name, employee_id, birth,day,month,year) { }
            public override void print()
            {

                Console.WriteLine($"the age of manager is :  {2022 - birth}\n\n\n");
            }

        }


        internal class Program
        {
            static void Main(string[] args)
            {
                manager employee1 = new manager("sohaib", 999999, 1999,24,07,1999);
                Console.WriteLine("the manager name is : " + " " +employee1.name+"\nthe birth is : "+employee1.birth);
               // Console.WriteLine("the age is : " + " " + employee1.age);
                Console.WriteLine("the manager id is : " + " " + employee1.employee_id);
                employee1.age();
                Employee employee2 = new Employee("alrousan", 988888, 1998,6,12,1998);
                Console.WriteLine("the name is : " + " " + employee2.name+"\nthe birth is : " + employee1.birth);
                Console.WriteLine("the employee id is : " + " " + employee2.employee_id);

                employee2.age();

            }
        }
    }
}
