using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresentOrNotRefactoring
{
    class WageUsingSwitch
    {
        //Fields
        int IsFullTime = 1;
        int IsPartTime = 2;

        int EmpRatePerHr = 200;

        //Constructor

        public WageUsingSwitch(int FullTime)
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
            switch (empCheck)
            {

            
            case 1:
            
                Console.WriteLine("Full Time Employee");
                EmpHr = 8;
                break;

            
            case 2:
            
                Console.WriteLine("Part Time Employee");
                EmpHr = 4;
                    break;


            default:
            
                Console.WriteLine("Employee is Absent");
                    EmpHr = 0;
                    break;

            }

            EmpWage = EmpHr * EmpRatePerHr;
            Console.WriteLine("Employee Wage is " + EmpWage);
        }
    }
}
