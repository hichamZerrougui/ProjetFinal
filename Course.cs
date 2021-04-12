using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class Course
    {
        public int NumeroDuCours { get; set; }
        public int Code { get; set; }
        public String Titre { get; set; }

        public Course()
        {

        }
        public Course(int numeroDuCours)
        {
            this.NumeroDuCours = numeroDuCours;
        }
        public Course( int classe ,int numeroDuCours, int code, String titre) : this(numeroDuCours)
        {
            this.Classe = classe;
            this.Code = code;
            this.Titre = titre;
            
        }














    }
}
