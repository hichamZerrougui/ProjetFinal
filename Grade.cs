using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class Grade
    {



        public List<Student> etudiantliste { get;set; } = new List<Student>();
        public List<Course> courslite{ get; set; } = new List<Course>();
        public double Note { get; set; }

        List<Grade> listenote = new List<Grade>();


        public Grade()
        {

        }

        
        
       
 

        public void Addcour(Course c) { this.courslite.Add(c); }

        public void Addcour(int classe, int numeroDuCours, int code, String titre) {this.Addcour(new Course( classe,  numeroDuCours,code, titre)); }


        public void Addetudiant(Student c) { this.etudiantliste.Add(c); }

        public void Addetudiant(int numeroEtudiant, String nom, String prenom) { this.Addetudiant(new Student(numeroEtudiant, nom,prenom)); }


        public void Addnote(Grade g) { 
            this.listenote.Add(g); 
        }

        public void Addnote(Student numeroEtudiant, Course numeroDuCours, double note)
        { this.Addetudiant(new Grade (numeroEtudiant, numeroDuCours, note)); }





    }
}
