using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Training.UI.ConsoleApp
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Mobile { get; set; }
        public virtual void AddEmployee()
        {
            Console.Write("Enter Id -> ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name -> ");
            Name = Console.ReadLine();

            Console.Write("Enter Department -> ");
            Department = Console.ReadLine();

            Console.Write("Enter Mobile -> ");
            Mobile = Console.ReadLine();
        }

        public virtual void PrintEmployee()
        {
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Department = " + Department);
            Console.WriteLine("Mobile = " + Mobile);
        }
    }
    class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        public string Benefits { get; set; }
        public override void AddEmployee()
        {

            base.AddEmployee();
            Console.Write("Enter Salary -> ");
            Salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Benefit -> ");
            Benefits = Console.ReadLine();
        }

        public override void PrintEmployee()
        {

            base.PrintEmployee();
            Console.WriteLine("Salary = " + Salary);
            Console.WriteLine("Benefits = " + Benefits);
        }
    }
    class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }

        public override void AddEmployee()
        {
            base.AddEmployee();
            Console.Write("Enter Hourly Rate -> ");
            HourlyRate = Convert.ToDecimal(Console.ReadLine());
        }

        public override void PrintEmployee()
        {
            base.PrintEmployee();
            Console.WriteLine("Hourly Rate = " + HourlyRate);
        }

    }

    class RemotelyWorkingEmployee : Employee
    {
        public override void AddEmployee()
        {
            base.AddEmployee();
            Console.WriteLine("Remotely working employee");
        }

        public override void PrintEmployee()
        {
            base.PrintEmployee();
            Console.WriteLine("Remotely working employee");
        }
    }
}
