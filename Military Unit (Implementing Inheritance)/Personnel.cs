using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit__Implementing_Inheritance_
{
    class Personnel
    {
        public virtual string Greet() => "You greet the person.";
        public string Uniform() => "You wear your military uniform to work everyday.";
        public virtual string Rank() => "You wear your rank insignia on your collar everyday.";

        public virtual string Correction() => "You need to try again.";
    }
}
