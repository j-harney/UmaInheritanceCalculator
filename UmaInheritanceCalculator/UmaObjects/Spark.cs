using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmaInheritanceCalculator.UmaObjects
{
    internal class Spark
    {
        public string SparkType;
        public string SparkName;
        public string SparkStars;

        private static Dictionary<string, string> Sparks => new Dictionary<string, string>()
        {
            ["Turf"] = "Red",
            ["Dirt"] = "Red",
            ["Sprint"] = "Red",
            ["Mile"] = "Red",
            ["Medium"] = "Red",
            ["Long"] = "Red",
            ["Front Runner"] = "Red",
            ["Pace Chaser"] = "Red",
            ["End Closer"] = "Red",
            ["Late Surger"] = "Red",
            ["Stamina"] = "Blue",
            ["Speed"] = "Blue",
            ["Power"] = "Blue",
            ["Wit"] = "Blue",
            ["Guts"] = "Blue",
        };

        public Spark(string SparkName, string SparkStars) 
        {
            SparkType = "White";
            if (SparkName == null) throw new ArgumentNullException(nameof(SparkName));
            
            foreach (string sparkNames in Sparks.Keys)
            {
                if (SparkName == sparkNames) 
                {
                    string localSparkType;
                    Sparks.TryGetValue(sparkNames, out localSparkType);
                    SparkType = localSparkType;
                }
            }
        }
    }
}
