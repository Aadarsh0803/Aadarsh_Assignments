using static Assignment6.IGovRules;
using System;
using System.Xml.Linq;

namespace Assignment6
{
    interface IGovRules
    {
        public double EmployeePF();
        public string LeaveDeatils();
        public double GratAmount(float serviceComplete);

        class TCS : IGovRules
        {
            int empid;
            string name, dept, desg;
            double salary, emppf, empcontribution, pension;
            float serviceComplete;
            public TCS(int empid, string name, string dept, string desg, double salary)
            {
                this.empid = empid;
                this.name = name;
                this.dept = dept;
                this.desg = desg;
                this.salary = salary;
            }

            public double EmployeePF()
            {

                emppf = (salary * 12) / 100;
                empcontribution = (salary * 8.33) / 100;
                pension = (salary * 3.67) / 100;

                return emppf + empcontribution + pension;
            }

            public string LeaveDeatils()
            {
                Console.WriteLine("Company : TCS");
                Console.WriteLine("1 Casual Leave per month\n12 days sick leaves per year\n10 days Pervilage leave per year");
                return "";
            }
            public double GratAmount(float serviceComplete)
            {
                if (serviceComplete > 5)
                {
                    return salary + (salary / 12);
                }
                else if (serviceComplete > 10)
                {
                    return salary + ((2 * salary) / 12);
                }
                else if (serviceComplete > 20)
                {
                    return (salary + ((3 * salary) / 12));
                }
                else
                {
                    return salary;
                }
            }
            public void Show()
            {
                Console.WriteLine($"Employee ID: {empid}\nEmployee Name: {name}\nDesignation: {desg}\nDepartment: {dept}\nSalary: {salary}\nEmployee PF: {emppf}\n");
            }
        }
        class Accenture : IGovRules
        {
            int empid;
            string name, dept, desg;
            double salary, emppf, empcontribution, pension;
            public Accenture(int empid, string name, string dept, string desg, double salary)
            {
                this.empid = empid;
                this.name = name;
                this.dept = dept;
                this.desg = desg;
                this.salary = salary;
            }
            public double EmployeePF()
            {
                emppf = (salary * 12) / 100;
                empcontribution = (salary * 12) / 100;
                return (emppf + empcontribution);
            }

            public string LeaveDeatils()
            {
                Console.WriteLine("Company : ACCENTURE");
                Console.WriteLine("2 Casual leaves per month\n 5 sick leaves per year\n 5 previlage leaces per year");
                return "";
            }
            public double GratAmount(float serviceComplete)
            {
                Console.WriteLine("Not applicable");
                return 0;
            }


            public void Show()
            {
                Console.WriteLine($"Employee ID: {empid}\nEmployee Name: {name}\nDesignation: {desg}\nDepartment: {dept}\nSalary: {salary}\nEmployee PF: {emppf}\n");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            TCS s2 = new TCS(101,"K","Development","Associate Engg",23445.7);
            s2.EmployeePF();
            s2.LeaveDeatils();
            s2.GratAmount(10);
            s2.Show();

            Accenture a = new Accenture(103, "a", "Developer", "HR", 76543.99);
            a.EmployeePF();
            a.LeaveDeatils();
            a.GratAmount(15);
            a.Show();
        }
    }
}
