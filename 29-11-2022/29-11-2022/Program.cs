using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_11_2022
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private int BirthDate;
        public int DateOfbirth
        {
            get { return BirthDate; }   
            set {
                if (value > 2022) { Console.WriteLine("Dear user : please enter a correct year"); }
                else { BirthDate = value; }
            }
        }

public Employee(int id, string name, int dateOfbirth)
        {
            Id = id;
            Name = name;
            DateOfbirth = dateOfbirth;
        }

        public Employee() { }
        public  void age()
        {

            int age = DateTime.Now.Year - DateOfbirth;
            Console.WriteLine("your age is :"+age);
        }

        public virtual void full_info()
        {
            Console.WriteLine($"Employee's Name : {Name}");
            Console.WriteLine($"Employee's id : {Id}");
            Console.WriteLine($"Employee's date of birth : {DateOfbirth}");
        }
    }

    class Manager : Employee
    {
       public Manager(int id,string name, int dateOfbirth):base(id, name, dateOfbirth) { 
        }

        public override void full_info()
        {
            Console.WriteLine($"Manager's Name : {Name}");
            Console.WriteLine($"Manager's id : {Id}");
            Console.WriteLine($"Manager's date of birth : {DateOfbirth}");
        }
    }





        internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "rama",2000);
            Manager manager1 = new Manager(1,"raghad", 2000);
            manager1.full_info();
            manager1.age();
            
        }
    }
}
