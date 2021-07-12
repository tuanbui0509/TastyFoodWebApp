using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyFoodSolution.Utilities.Exceptions
{
    public class TastyFoodException:Exception
    {
        public TastyFoodException()
        {

        }

        public TastyFoodException(string message):base(message)
        {

        }

        public TastyFoodException(string message,Exception inner) : base(message,inner)
        {

        }
    }
}
