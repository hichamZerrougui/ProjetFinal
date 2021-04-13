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

        public List<Student> etudiantliste { get; set; } = new List<Student>();


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
        public void Ajouteretudiant(Student etudiant) { this.etudiantliste.Add(etudiant); }
        public void Ajouteretudiant( int numeroEtudiant, String nom, String prenom) { this.Ajouteretudiant(new Student(numeroEtudiant,nom,prenom)); }

        public Student FindStudent(string nom, String prenom)
        {
            Student cRes = null;
            foreach (Student e in etudiantliste)
                if (e.Nom == nom && e.Prenom ==prenom) { cRes = e; break; }
            return cRes;
        }
        public Student FindStudent(int numeroetudiant)
        {
            Student cRes = null;
            foreach (Student e in etudiantliste)
                if (e.NumeroEtudiant == numeroetudiant) { cRes = e; break; }
            return cRes;
        }

        public void Supprimeretudiant(int numeroetudiant)
        {
            this.etudiantliste.Remove(this.FindStudent(numeroetudiant));
        }







    }
}
