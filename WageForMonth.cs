using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresentOrNotRefactoring
{
    class WageForMonth
    {
        //Fields
        int FullTime = 1;
        int HalfTIme = 2;


        int EmpRatePerHr = 200;
        int NumberOfWorkingDays = 20;

        //Constructor

        public WageForMonth(int FullTime)
        {
            this.FullTime = FullTime;
        }


        Random random = new Random();

        //Methods
        public void Solution()
        {
            int empWage;
            int totalEmpWage =0;
            int empHrs;
            for (int day = 0; day < NumberOfWorkingDays; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(1, 4);
                switch (empCheck)
                {
                    case 1:
                        Console.WriteLine("Employee is full Time");
                        empHrs = 8;
                        break;

                    case 2:
                       Console.WriteLine("Employee is Part Time");

                        empHrs = 4;
                        break;
                    default:
                       Console.WriteLine("Employee is Absent");

                        empHrs = 0;
                        break;

                }
                empWage = empHrs * EmpRatePerHr;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage : " + empWage);


            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
}   }
