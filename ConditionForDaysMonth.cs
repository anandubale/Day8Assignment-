using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresentOrNotRefactoring
{
    class MinNumberOfDayandHrs
    {
        //Fields
        int FullTime = 1;
        int HalfTIme = 2;


        int EmpRatePerHr = 200;
        int NumberOfWorkingDays = 0;

        //Constructor

        public MinNumberOfDayandHrs(int FullTime)
        {
            this.FullTime = FullTime;
        }


        Random random = new Random();

        //Methods
        public void Solution()
        {
            int empWage;
            int totalEmpWage = 0;
            int empHrs = 0;
            int totalWorlkingHr = 0;
            int day = 0;
            while (day <= 20 || totalWorlkingHr <= 100)
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
                totalWorlkingHr += empHrs;
                Console.WriteLine("Total Emp Hr : " + totalWorlkingHr);
                Console.WriteLine("Employee Wage : " + empWage);

                day++;

                totalWorlkingHr++;


            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            Console.WriteLine("Total Emp Hr : " + totalWorlkingHr);

        }
    }
}
