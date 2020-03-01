using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit__Implementing_Inheritance_
{
    class Knife : Weapons
    {
        public override string Description() => "This is a simple knife you can carry.";
        public override string Carry() => "(You clip the knife on your belt)";
        public override string Stage() => "(the knife stays on your body.)";
        public override string Use() => "(You use your knife.)";

    }
}
