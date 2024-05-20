using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ArraysExample2
{
    class Program
    {
        static void Main()
        {
            Class1 emp1 = new Class1() { EmpId=1,Name="Mohith"};
            Class1 emp2 = new Class1() { EmpId = 2, Name = "Rohith" };
            Class1 emp3 = new Class1() { EmpId = 3, Name = "Ramesh" };
            Class1 emp4 = new Class1() { EmpId = 4, Name = "Suresh" };

            Class1[] array= new Class1[] { emp1, emp2, emp3, emp4 };
            foreach(Class1 obj in array)
            {
                Console.WriteLine(obj.EmpId+","+obj.Name);
            }
            Console.ReadKey();

        }
    }
}
