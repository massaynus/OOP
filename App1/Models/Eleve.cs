using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class Eleve : Personne
    {
        public Teacher Teacher { get; set; }

        public override string DoJob()
        {
            return "Study";
        }
    }
}
