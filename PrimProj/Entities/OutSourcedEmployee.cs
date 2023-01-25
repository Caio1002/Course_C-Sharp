using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimProj.Entities
{
    internal class OutSourcedEmployee : Employee
    {
        /*
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i} data: ");//interpolação
                Console.Write("OutSourcered: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                } else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();

            Console.WriteLine("Payments: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.payment().ToString("F2", CultureInfo.InvariantCulture));
            }
            */

        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee()
        {

        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            :base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double payment()
        {
            return base.payment() + 1.1 * AdditionalCharge;
        }

    }

}
