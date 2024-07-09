using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class EmployeeRunner
    {
        public static void Main(string[] args)
        {

            Employee.companyName = "KPMG";

            Employee emp1 = new Employee(10.2, 2);
            Employee emp2 = new Employee(102);
            Employee emp3 = new Employee(103);
            Employee emp4 = new Employee(104.2);

            Console.WriteLine()

            //load 1st employee details
            //emp1.empId = -101;
            emp1.EmpId = 99;
            emp1.empName = "John";
            emp1.empSalary = 9000;

            //load 2nd employee details
            //emp2.empId = 102;
            emp2.EmpId = 102;
            emp2.empName = "Saul";
            emp2.empSalary = 7000;


            emp1.PrintEmployeeDetails();
            emp2.PrintEmployeeDetails();
            emp3.PrintEmployeeDetails();

            Employee.EmployeeGreetings(emp2);

            string greeting = Employee.GetEmployeeGreetings(emp2);
            Console.WriteLine(greeting);

            Console.WriteLine(emp1.EmpId);

            //Employee emp4= Employee.GetEmployeeInstance();
            //emp4.EmpId = 104;
            //emp4.PrintEmployeeDetails();

            //Employee emp5 = Employee.GetEmployeeInstance();
            //emp5.EmpId = 105;
            //emp5.empName = "Bala";
            //emp5.PrintEmployeeDetails();

          

        }
    }
}
