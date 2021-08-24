using System;

namespace SampleApp
{
     
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Updated!");
            Employee employee = new Employee{Id=101,Name="Rabbu",Salary=96000};
            Console.WriteLine(employee);
        }
    }
}
