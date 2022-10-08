using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.OCPBad
{
 




    public class SalaryCalculator
    {

        public decimal Calculate(decimal salary, SalaryType salaryType)
        {
            decimal newSalary = 0;

            switch (salaryType)
            {
                case SalaryType.Low:
                    newSalary = salary * 2; ;
                    
                    break;
                case SalaryType.Middle:
                    newSalary = salary * 4 ;
                    break;
                case SalaryType.High:

                    newSalary = salary * 6; ;
                    break;
                default:
                    break;
            }

            return newSalary;



        }


    }

  public   enum SalaryType
    {
        Low,
        Middle,
        High,
        
    }
}
