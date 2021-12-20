using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresentOrNotRefactoring
{
    class PresentOrNot
    {
        //fields
        int IsFullTime ;

        //Constructor
        public PresentOrNot(int FullTime)
        {
            this.IsFullTime = FullTime;
        }

        Random random = new Random();

        //Mathods
        public void Solution()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == IsFullTime)
            {
                Console.WriteLine("Employee is Present ");
            }
            else
            {
                Console.WriteLine("Employee is Absent ");
            }

        }

    }
}
