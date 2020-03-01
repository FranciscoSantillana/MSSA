using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit__Implementing_Inheritance_
{
    class Officer: Personnel
    {
        public override string Greet() => "(You get saluted by enlisted personnel)";
        public override string Rank() => "The rank insignia you wear is shiny.";

        public override string Correction() => "Do not salute me indoors.";
        public string Mission1() => $"Colonel Eagle: Your mission is to ensure that your unit is ready.\n" +
        "You will inspect your unit to ensure that you have everyone, all the weapons, and all the gear.\n" +
            "Oh, and Captain, that includes you too.\n\n" +
            
            "Press [Enter] to continue.\n";
        public string Setting() => "Today is a perfect day. The sun is shining bright and everything is in order.\n" +
            "There's not much to do today. Maybe you'll let your unit go home ear......\n" +
            "Is that your office phone ringing?\n";
        public string EndSetting() => "Sgt Motivation: Everyone is ready, Captain. \n\n" +
            "You walk towards your unit and everyone is formed up awaiting your inspection.\n" +
            "You inspect the unit.........\n\n" +
            "Everyone brought all of the essentials. You're pleased to see that the unit is prepared.\n" +
            "You call Colonel Eagle and report to him that the unit is mission ready.\n\n\n" +
            "The End!";

        
    }
}
