using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegictrationApp.BUSINESS
{
    public static class Common
    {
        public static string returnMessageEmptyValue()
        {
            return "You did not fill all required fields!";
        }
        public static string returnMessagePersonExist()
        {
            return "The person has already been registered!";
        }
    }
}
