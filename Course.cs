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

        public List<Course> courslite { get; set; } = new List<Course>();

        public Course()
        {

        }
        public Course(int numeroDuCours)
        {
            this.NumeroDuCours = numeroDuCours;
        }
        public Course(int numeroDuCours, int code, String titre) : this(numeroDuCours)
        {
          
            this.Code = code;
            this.Titre = titre;
            
        }


        public void Ajoutercours(Course cours) { this.courslite.Add(cours); }
        public void Ajouterecours(int numeroDuCours, int code, String titre) { this.Ajoutercours(new Course(numeroDuCours,code,titre)); }

        public Course Findcours(int code, String titre)
        {
            Course cRes = null;
            foreach (Course c in courslite)
                if (c.Code == code && c.Titre == titre) { cRes = c; break; }
            return cRes;
        }
        public Course Findcours(int numerocours)
        {
            Course cRes = null;
            foreach (Course c in courslite)
                if (c.NumeroDuCours == numerocours) { cRes = c; break; }
            return cRes;
        }

        public void Supprimercours(int numerocours)
        {
            this.courslite.Remove(this.Findcours(numerocours));
        }



        










    }
}
