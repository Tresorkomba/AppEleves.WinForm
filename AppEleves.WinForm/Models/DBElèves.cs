using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEleves.WinForm.Models
{
    public static class DBElèves
    {
        public static List<Elèves> lstElèves;
        // Ajouter un élève à la liste des élèves
        public static int AddElèves(Elèves c)
    {
        if (lstElèves == null)
        {
                lstElèves = new List<Elèves>();
         }
            c.Id = lstElèves.Any() ? lstElèves.Max(x => x.Id) + 1 : 100; //lambda Expressions
            lstElèves.Add(c);
            return c.Id;
        }
        // Récuperer la liste des élèves
        public static List<Elèves> GetListElèves()
        {
            return lstElèves;
        }
        // Supprimer un élève
        public static void DeleteElèves(int idElèves)
        {
            int index = lstElèves.FindIndex(x => x.Id == idElèves);
            lstElèves.RemoveAt(index);
        }
        // Modifier un élève
        public static void UpdateElèves(Elèves c)
        {
            Elèves rech = lstElèves.FirstOrDefault(x => x.Id == c.Id);
            rech.NumPerm = c.NumPerm;
            rech.NomComplet = c.NomComplet;
            rech.DateNaiss = c.DateNaiss;
            rech.LieuNaiss = c.LieuNaiss;
            rech.Sexe = c.Sexe;
            rech.Classe = c.Classe;
            rech.Option = c.Option;
            rech.Niveau = c.Niveau;
            rech.AnneeScol = c.AnneeScol;
            rech.NomPere = c.NomPere;
            rech.NomMere = c.NomMere;
            rech.Tel = c.Tel;
            rech.Adresse = c.Adresse;
            rech.Photo = c.Photo;
        }
        // Chercher par nom
        public static List<Elèves> SearchElèves (string name)
        {
            List<Elèves> res = lstElèves.Where(x => x.NomComplet.ToLower().Contains(name.ToLower())).ToList();
            return res;
        }
    }
}