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
        //int birth_of_date { get; set; }
        int employee_id { get; set; }
        int age { get; set; }
        public Employee() { }
        public Employee(string name, int employee_id, int age)
        {
            this.name = name;
            //this.birth_of_date = birth_of_date;
            this.employee_id = employee_id;
            this.age = age;
        }

        public virtual void Age()
        {
            Console.WriteLine("the age of employee is : ");
            Console.WriteLine(2022-age);
        }

        class manager : Employee
        {
            public manager(string name, int employee_id, int age) : base(name, employee_id, age) { }
            public override void Age()
            {

                Console.WriteLine(2022 - age);
            }

        }


        internal class Program
        {
            static void Main(string[] args)
            {
                manager employee1 = new manager("sohaib", 999999, 1999);
                Console.WriteLine("the name is : " + " " +employee1.name);
               // Console.WriteLine("the age is : " + " " + employee1.age);
                Console.WriteLine("the employee id is : " + " " + employee1.employee_id);
                employee1.Age();
                Employee employee2 = new Employee("alrousan", 988888, 1998);
                employee2.Age();

            }
        }
    }
}
