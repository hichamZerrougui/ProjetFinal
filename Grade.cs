using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class Grade
    {

        public int NumeroEtudiant { get; set; }
        public int NumeroDuCours { get; set; }
        public double Note { get; set; }
        public List<Grade> gradliste { get; set; } = new List<Grade>();



        public Grade()
        {

        }
        
        
        public Grade(int numeroEtudiant, int numeroDuCours, double note) 
        {
            this.NumeroEtudiant = numeroEtudiant;
            this.NumeroDuCours = numeroDuCours;
            this.Note = note;
        }


        public void Ajouternote(Grade note) { this.gradliste.Add(note); }
        public void Ajouternote(int numeroEtudiant, int numeroDuCours, double note) { this.Ajouternote(new Grade(numeroEtudiant,numeroDuCours,note)); }

        public Grade Findnote(int numeroEtudiant)
        {
            Grade cRes = null;
            foreach (Grade n in gradliste)
                if (n.NumeroEtudiant == numeroEtudiant) { cRes = n; break; }
            return cRes;
        }
        public Grade Findnote(int numeroEtudiant, int numerocours)
        {
            Grade cRes = null;
            foreach (Grade n in gradliste)
                if (n.NumeroEtudiant == numeroEtudiant && n.NumeroDuCours== numerocours) { cRes = n; break; }
            return cRes;
        }

      

        public void Supprimercours(int numeroetudiant)
        {
            this.gradliste.Remove(this.Findnote(numeroetudiant));
        }


















    }
}
