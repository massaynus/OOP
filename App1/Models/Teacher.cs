using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class Teacher : Personne
    {
        public int NombreEleve { get; set; }
        public List<Eleve> Eleves { get; set; }

        public Teacher()
        {
            Eleves = new List<Eleve>();
        }

        public override string DoJob()
        {
            return $"{base.DoJob()} AND Teach";
        }
    }
}
