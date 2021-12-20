using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresentOrNotRefactoring
{
    class PartTimeEmployee
    {
        //Fields
        int IsFullTime = 1;
        int IsPartTime = 2;

        int EmpRatePerHr = 200;

        //Constructor

        public PartTimeEmployee(int FullTime)
        {
            this.IsFullTime = FullTime;
        }


        Random random = new Random();

        //Methods
        public void Solution()
        {
            int EmpHr = 0;
            int EmpWage = 0;


            int empCheck = random.Next(0, 3);
            if (empCheck == IsFullTime)
            {
                Console.WriteLine("Full Time Employee");
                EmpHr = 8;

            }
            else if(empCheck == IsPartTime)
            {
                Console.WriteLine("Part Time Employee");

                EmpHr = 4;

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            EmpWage = EmpHr * EmpRatePerHr;
            Console.WriteLine("Employee Wage is " + EmpWage);
        }
    }
}
