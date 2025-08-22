using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmaInheritanceCalculator.UmaObjects
{
    internal class UmaDB
    {
        public static Dictionary<string, string> Umas;
        static UmaDB()
        {
            Umas = new Dictionary<string, string>()
            {
                ["U=ma2"] = "Agnes Tachyon",
                ["Pure Heart"] = "Super Creek",
                ["Superior Heal"] = "Grass Wonder",
                ["Dazzl'n ♪ Diver"] = "Special Week",
                ["Certain Victory"] = "Tokai Teio",
                ["Legacy of the Strong"] = "Mejiro McQueen",
                ["The View from the Lead Is Mine!"] = "Silence Suzuka",
                ["Sky-High Teio Step"] = "Tokai Teio",
                ["Triumphant Pulse"] = "Oguri Cap",
                ["Anchors Aweigh!"] = "Gold Ship",
                ["Cut and Drive!"] = "Vodka",
                ["Resplendent Red Ace"] = "Daiwa Scarlet",
                ["Where There's a Will, There's a Way"] = "Grass Wonder",
                ["The Duty of Dignity Calls"] = "Mejiro McQueen",
                ["Victoria por plancha ☆"] = "El Condor Pasa",
                ["This Dance Is for Vittoria!"] = "TM Opera O",
                ["Behold Thine Emperor's Divine Might"] = "Symboli Rudolf",
                ["Blazing Pride"] = "Air Groove",
                ["∴win Q.E.D."] = "Biwa Hayahide",
                ["Flashy☆Landing"] = "Mayano Top Gun",
                ["G00 1st. F∞;"] = "Mihono Bourbon",
                ["Blue Rose Closer"] = "Rice Shower",
                ["Our Ticket to Win!"] = "Winning Ticket",
                ["Genius x Bakushin = Victory"] = "Sakura Bakushin O",
                ["I See Victory in My Future!"] = "Matikanefukukitaru",
                ["Just a Little Farther!"] = "Nice Nature",
                ["Prideful King"] = "King Halo",
                ["#LookatCurren"] = "Curren Chan",
                ["Nemesis"] = "Narita Taishin",
                ["SPARKLY☆STARDOM"] = "Smart Falcon",
                ["Shadow Break"] = "Narita Brian",
                ["Eternal Moments"] = "Air Groove",
                ["Flowery☆Maneuver"] = "Mayano Top Gun",
                ["You and Me! One-on-One!"] = "Hishi Amazon",
                ["Lights of Vaudeville"] = "Fuji Kiseki",
                ["KEEP IT REAL."] = "Gold City",
                ["A Kiss for Courage"] = "Maruzensky",
                ["I Never Goof Up!"] = "Meisho Doto",
                ["Schwarzes Schwert"] = "Eishin Flash",
                ["Bountiful Harvest"] = "Matikanefukukitaru",
                ["Let's Pump Some Iron!"] = "Mejiro Ryan",
                ["Angling and Scheming"] = "Seiun Sky",
                ["Condor's Fury"] = "El Condor Pasa"
            };
        }
    }
};
