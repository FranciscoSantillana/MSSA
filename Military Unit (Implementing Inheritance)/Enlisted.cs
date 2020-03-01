using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit__Implementing_Inheritance_
{
    class Enlisted : Personnel
    {
        public override string Greet() => "(You saluted officer)";
        public string Correction2() => "Sgt Motivation: Unless my eyes need to be checked, I did not see you salute the Company Commander.";
        public override string Rank()
        {
            return "The rank insignia you wear is black";
        }
        public string Mission1() => "Fix your uniform, Grab your weapons, grab your gear, and form it up outside.";
        public override string Correction() => "Sgt Motivation: Unless my hearing needs to be checked, I did not hear a proper response motivator.";
        public string Setting() => "...You joined the military and now you have some tasks...\n" +
        "You just want to go home and play video games, you also need to get laundry don... \n";
        public string EndSetting() => "You grabbed everything that you needed for the inspection.\n" +
            "You run to formation and your unit gets inspected by the Captain.....\n" +
            "The Company Commander is pleased with what he sees. The unit is mission ready.\n\n\n" +
            "The End!";
    }
}
