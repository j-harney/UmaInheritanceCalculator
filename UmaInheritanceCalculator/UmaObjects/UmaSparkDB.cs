using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UmaInheritanceCalculator.UmaObjects
{
    internal class UmaSparkDB
    {
        public static Dictionary<string, Dictionary<string, double>> SparkDB { get; set; }
        public UmaSparkDB() 
        {
            var blueSpark = new Dictionary<string, double>()
            {
                ["One"]=0.70,
                ["Two"]=0.80,
                ["Three"]=0.90
            };

            var redSpark = new Dictionary<string, double>()
            {
                ["One"] = 0.01,
                ["Two"] = 0.03,
                ["Three"] = 0.05
            };

            var whiteSpark = new Dictionary<string, double>()
            {
                ["One"] = 0.03,
                ["Two"] = 0.06,
                ["Three"] = 0.09
            };

            var whiteRaceSpark = new Dictionary<string, double>()
            {
                ["One"] = 0.01,
                ["Two"] = 0.02,
                ["Three"] = 0.03
            };

            var greenSpark = new Dictionary<string, double>()
            {
                ["One"] = 0.05,
                ["Two"] = 0.10,
                ["Three"] = 0.15
            };

            SparkDB = new Dictionary<string, Dictionary<string, double>>()
            {
                ["Blue"] = blueSpark,
                ["Red"] = redSpark,
                ["White"] = whiteSpark,
                ["White Race"] = whiteRaceSpark,
                ["Green"] = greenSpark
            };
        }

        public static double GetSparkChance(Spark spark)
        {
            if (SparkDB.ContainsKey(spark.SparkName)) {
                return SparkDB.GetValueOrDefault(spark.SparkName).GetValueOrDefault(spark.SparkStars);
            }
            else
            {
                return 0;
            }
        }
    }
}
