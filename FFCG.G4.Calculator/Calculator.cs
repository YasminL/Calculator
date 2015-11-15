using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFCG.G4.Calculator
{
    public class Calculator
    {
        public int add(int firstTerm, int secondTerm)
        {
            return firstTerm + secondTerm;
        }

        public int subtract(int firstTerm, int secondTerm)
        {
            return firstTerm - secondTerm;
        }

        public int multiply(int firstTerm, int secondTerm)
        {
            return firstTerm*secondTerm;
        }

        public int divide(int firstTerm, int secondTerm)
        {
            return firstTerm/secondTerm;
        }
    }
}
