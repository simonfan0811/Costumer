using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Training.UI.ConsoleApp
{
    class EmployeeFactory
    {
        public Employee GetObject(int choice)
        {
            switch (choice)
            {
                case (int)Options.FullTimeEmployee:
                    return new FullTimeEmployee();

                case (int)Options.PartTimeEmployee:
                    return new PartTimeEmployee();
                case (int)Options.RemotelyWorkingEmployee:
                    return new RemotelyWorkingEmployee();
                default:
                    Console.WriteLine("Invalid Option");
                    return null;
            }
        }
    }
}
