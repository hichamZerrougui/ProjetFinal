using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class Student
    {
        public int NumeroEtudiant { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
      

        public Student()
        {

        }
        public Student(int numeroEtudiant)
        {
            this.NumeroEtudiant = numeroEtudiant;
        }
        public Student(int numeroEtudiant, String nom, String prenom) : this(numeroEtudiant)
        {
            
            this.Nom = nom;
            this.Prenom = prenom;
        }



    }
}
