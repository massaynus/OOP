using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DTN { get; set; }

        public virtual string DoJob()
        {
            return "Walk";
        }

        public int CalculerAge()
        { 
            TimeSpan time = DateTime.Now - DTN;
            return (int)(time.TotalDays / 365);
        }
    }
}
