using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmaInheritanceCalculator.UmaObjects;

namespace UmaInheritanceCalculator.UmaCalculations
{
    internal class UmaCalculator
    {
        private double parentToParentScore;
        public UmaCalculator(List<Uma> umas)
        {
        }

        public double CalculateUmaSparkChance(Spark spark)
        {
            return (1 + 0/100) * (UmaSparkDB.GetSparkChance(spark));
        }

        
        public double CalculateCompatibilityScore(Uma uma)
        {
            return 
        }

        public double CalculateCompatibilityScore(List<Uma> umas)
        {

        }
    }
}
