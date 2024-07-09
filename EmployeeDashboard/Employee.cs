using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    //Employee Template or User definded datatype
    public class Employee
    {
        private int empId;
        public string empName;
        public double empSalary;
        public static string companyName;

        public Employee(int empId)
        {
            Console.WriteLine("Object created");
            Console.WriteLine("Launch browser");
            if(empId>100)
            {
                this.empId = empId;
              
            } 
        }

        public Employee(double a)
        {
           
        }
        public Employee(double a,int b)
        {

        }
        public Employee(int a,double b)
        {

        }

        public int EmpId
        {
            get { 
                return empId; 
            }

            set
            {
                if (value >= 100)
                {
                    empId = value;
                }
                else
                {
                    Console.WriteLine("Invalid id - now id is retained as 0");
                }
            }
        }

        //create a method to print employee detail
        public void PrintEmployeeDetails()
        {
            int empId = 0;
            Console.WriteLine("Employee Id: " + this.empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Salary: " + empSalary);
            Console.WriteLine("Company Name: " + Employee.companyName);
            Console.WriteLine("----------------------------------------------------------");
        }

        public static void PrintEmpDetail(Employee x)
        {
            Console.WriteLine(x.empId);
            Console.WriteLine(x.empName);
        }

        public static void EmployeeGreetings(Employee e)
        {
            Console.WriteLine("Hello " + e.empName + " \n Welcome to the " + Employee.companyName);
        }

        public static string GetEmployeeGreetings(Employee e)
        {
           return ("Hello " + e.empName + "\n Welcome to the " + Employee.companyName);
        }

        //public  void EmployeeGreetings()
        //{
        //    Console.WriteLine("Hello " + empName + " \n Welcome to the " + Employee.companyName);
        //}

        //public static Employee GetEmployeeInstance()
        //{
        //   Employee employee = new Employee();
        //    return employee;
        //}
    }
}
