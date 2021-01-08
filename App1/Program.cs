using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;


namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.Prenom = "p1";
            p1.DTN = new DateTime(1968, 11, 7);

            Teacher t1 = new Teacher();
            t1.Prenom = "Yassine";
            t1.DTN = new DateTime(2000, 11, 7);
            t1.NombreEleve = 12;

            Eleve e1 = new Eleve()
            {
                Prenom = "Mohammed",
                Teacher = t1
            };



            WriteLine("p1 " + p1.DoJob());
            WriteLine("t1 " + t1.DoJob());
            WriteLine("e1 " + e1.DoJob());
            ReadLine();
        }
    }
}
