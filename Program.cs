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

            DailyEmployeeWage W1 = new DailyEmployeeWage(1);
            W1.Solution();

        }
    }
}
