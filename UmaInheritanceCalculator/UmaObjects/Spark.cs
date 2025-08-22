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
            ["Asahi Hai F.S."] = "White Race",
            ["February S."] = "White Race",
            ["Takamatsunomiya Kinen"] = "White Race",
            ["Osaka Hai"] = "White Race",
            ["Oka Sho"] = "White Race",
            ["Satsuki Sho"] = "White Race",
            ["Tenno Sho (Spring)"] = "White Race",
            ["NHK Mile C."] = "White Race",
            ["Victoria Mile"] = "White Race",
            ["Japanese Oaks"] = "White Race",
            ["Japanese Derby"] = "White Race",
            ["Yasuda Kinen"] = "White Race",
            ["Takarazuka Kinen"] = "White Race",
            ["Sprinters S."] = "White Race",
            ["Shuka Sho"] = "White Race",
            ["Kikuka Sho"] = "White Race",
            ["Tenno Sho (Autumn)"] = "White Race",
            ["Queen Elizabeth II Cup"] = "White Race",
            ["Mile Ch."] = "White Race",
            ["Japan C."] = "White Race",
            ["Champions C."] = "White Race",
            ["Hanshin J.F."] = "White Race",
            ["Hopeful S."] = "White Race",
            ["Arima Kinen"] = "White Race",
            ["Teio Sho"] = "White Race",
            ["J.D. Derby"] = "White Race",
            ["JBC L. Classic"] = "White Race",
            ["JBC Sprint"] = "White Race",
            ["JBC Classic"] = "White Race",
            ["Tokyo Daishoten"] = "White Race"
        };

        public Spark(string SparkName, string SparkStars) 
        {
            this.SparkStars = SparkStars;
            this.SparkType = "White";
            if (SparkName == null) throw new ArgumentNullException(nameof(SparkName));
            
            foreach (string sparkNames in Sparks.Keys)
            {
                if (SparkName == sparkNames) 
                {
                    string localSparkType;
                    Sparks.TryGetValue(sparkNames, out localSparkType);
                    this.SparkType = localSparkType;
                }
            }
        }
    }
}
