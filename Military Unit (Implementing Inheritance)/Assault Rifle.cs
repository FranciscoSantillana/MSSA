using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit__Implementing_Inheritance_
{
    class Assault_Rifle : Weapons
    {
        public override string Description() => "This weapon is an assault rifle. It is gas-chambered and can shoot single fire or bursts.\n" +
                                               "It is the standard weapon your unit uses.";
        public override string Use() => "You fired your weapon";
        public override string Stage() => "You placed the weapon down";
        public override string Carry() => "You are carrying your weapon";

    }
}
