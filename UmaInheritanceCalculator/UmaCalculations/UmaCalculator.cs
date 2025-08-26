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
        private List<Uma> UmaParentOneLineage;
        private List<Uma> UmaParentTwoLineage;

        public UmaCalculator(List<Uma> umaParentTwoLineage, List<Uma> umaParentOneLineage)
        {
            UmaParentOneLineage = umaParentOneLineage;
            UmaParentTwoLineage = umaParentTwoLineage;
        }

        public double CalculateUmaSparkChance(Spark spark, int compatibilityScore)
        {
            return (1 + compatibilityScore / 100) * (UmaSparkDB.GetSparkChance(spark));
        }

        public List<int> CalculateCompatibilityScores()
        {
            List<int> compatibilityScores = [0, 0];
            if (UmaParentOneLineage.Count == 0 || UmaParentTwoLineage.Count == 0)
            {
                return compatibilityScores;
            }
            else
            {
                compatibilityScores[0] = CalculateCompatibilityScore(UmaParentOneLineage);
                compatibilityScores[1] = CalculateCompatibilityScore(UmaParentTwoLineage);
                return compatibilityScores;
            }
        }

        public int CalculateCompatibilityScore(List<Uma> umas)
        {
            var compatibilityScore = 0;
            foreach (Uma uma in umas)
            {
                compatibilityScore += uma.CompatibilityScore;
            }
            return compatibilityScore;
        }
    }
}
