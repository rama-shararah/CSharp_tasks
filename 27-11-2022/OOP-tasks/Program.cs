using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tasks
{
    internal class Information
    {
        int Age;
        string Gender;
        string Name;
        string Email;
        int Id;
        string Phone;

        public Information(int age, string gender, string name, string email, int id, string phone)
        {
           if(age<18 || age > 60)
            {
                Console.WriteLine("Dear User : sorry you should be between 18-60");
                
            }
           else { Age = age; }
           Gender= gender;  
            Name = name;
            Email = email;
            Id = id;
            string first3 = phone.Substring(0, 3);
            if(first3=="077"|| first3 == "078" || first3 == "079")
            {
                Phone= phone;
            }
            else
            {
                Console.WriteLine("Dear User : your phone num shoud start with 077 or 078 or 179");
            }

        }



        static void Main(string[] args)
        {
            Information person1 = new Information(1, "female", "rama", "rama@gmail.com", 1, "0756610148");
            Console.WriteLine("Name :"+ person1.Name);
            Console.WriteLine("age :" + person1.Age);
            Console.WriteLine("Gender :"+ person1.Gender);
            Console.WriteLine("id :" + person1.Id);
            Console.WriteLine("E-mail :" + person1.Email);
            Console.WriteLine("Phone :" + person1.Phone);


        }
    }



}
