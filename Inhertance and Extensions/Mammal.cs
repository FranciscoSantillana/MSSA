using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_and_Extensions
{
    class Mammal
    {
        public string Habitat { get; set; }
        public virtual string Iam() =>  "I'm a mammal";
        public virtual string Breathe()
        {
            return "breathing normally";
        }
      
    }
}
