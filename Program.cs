using System;

namespace EmployeePresentOrNotRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Computation Problems.");

            /*
            PresentOrNot p1 = new PresentOrNot(1);
            p1.Solution();
            */

            /*
            DailyEmployeeWage W1 = new DailyEmployeeWage(1);
            W1.Solution();
            */

            /*
            PartTimeEmployee P1 = new PartTimeEmployee(1);
            P1.Solution();
            */

            /*
            WageUsingSwitch s1 = new WageUsingSwitch(1);
            s1.Solution();
            */

            
            WageForMonth s1 = new WageForMonth(1);
            s1.Solution();
            

            /*
            MinNumberOfDayandHrs m1 = new MinNumberOfDayandHrs(1);
            m1.Solution();
            */
        }
    }
}
