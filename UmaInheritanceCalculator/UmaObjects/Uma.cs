using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmaInheritanceCalculator.UmaObjects
{
    internal class Uma
    {
        public string Name { get; set; }
        public string ParentStatus { get; set; }
        public List<Spark> Sparks { get; set; }

        public int CompatibilityScore { get; set; }

        public Uma(string umaName, string umaParentStatus, List<Spark> umaSparks, int CompatibilityScore)
        {
            Name = umaName;
            foreach (var spark in umaSparks)
            {
                if (UmaDB.Umas.ContainsKey(spark.SparkName))
                {
                    Name = UmaDB.Umas.GetValueOrDefault(spark.SparkName);
                }
            }
            ParentStatus = umaParentStatus;
            Sparks= umaSparks;
        }
    }
}
