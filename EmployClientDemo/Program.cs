using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.EmployServiceClient client = new ServiceReference1.EmployServiceClient();
            ServiceReference1.emp[] result = client.ShowEmploy();

            foreach (ServiceReference1.emp e in result)
            {
                Console.WriteLine("Employ No " +e.Empno);
                Console.WriteLine("Employ Name " + e.Name);
                Console.WriteLine("Department " + e.Dept);
                Console.WriteLine("Designation " + e.Desig);
                Console.WriteLine("Basic " + e.Basic);
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
