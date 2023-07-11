using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("welcome");
            //Console.ReadKey();
            //string firstName;
            //string lastName;
            //Console.WriteLine("enter first name");
            //firstName = Console.ReadLine();
            /*Console.WriteLine("enter second name");
            lastName = Console.ReadLine();
            Console.WriteLine("welcome! "+firstName+" "+lastName);
            Console.ReadKey();*/

            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter grade");
            grade = char.Parse(Console.ReadLine());
            Console.WriteLine("enter doj");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("enter salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Name:\t"+name+"\n Age:\t "+age+"\nGrade:\t"+grade+"\nDOJ:\t"+doj+"\nSalary:\t"+salary);
            Console.ReadKey();

        }
    }
}
