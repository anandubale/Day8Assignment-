using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresentOrNotRefactoring
{
    class DailyEmployeeWage
    {
        //Fields
        int IsFullTime = 1;
        int EmpRatePerHr = 200;

        //Constructor

        public DailyEmployeeWage(int FullTime)
        {
            this.IsFullTime = FullTime;
        }


        Random random = new Random();

        //Methods
        public void Solution()
        {
            int EmpHr = 0;
            int EmpWage = 0;


            int empCheck = random.Next(0, 2);
            if (empCheck == IsFullTime)
            {
                EmpHr = 0;

            }
            else
            {
                EmpHr = 1;
            }

            EmpWage = EmpHr * EmpRatePerHr;
            Console.WriteLine("Employee Wage is " + EmpWage);
        }


    }
}
