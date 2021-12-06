using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEleves.WinForm.Models
{
    public class Elèves
    {
        public int Id { get; set; }
        public string NumPerm { get; set; }
        public string NomComplet { get; set; }
        public DateTime DateNaiss { get; set; }
        public string LieuNaiss { get; set; }
        public string Sexe { get; set; }
        public string Classe { get; set; }
        public string Option { get; set; }
        public string Niveau { get; set; }
        public string AnneeScol { get; set; }
        public string NomPere { get; set; }
        public string NomMere { get; set; }
        public string Tel { get; set; }
        public string Adresse { get; set; }
        public byte[] Photo { get; set; }

        public Elèves(string numPerm, string nomComplet, DateTime dateNaiss, string lieuNaiss, string sexe, string classe, string option, string niveau, string anneeScol, string nomPere, string nomMere, string tel, string adresse, byte[] photo)
        {
            this.NumPerm = numPerm;
            this.NomComplet = nomComplet;
            this.DateNaiss = dateNaiss;
            this.LieuNaiss = lieuNaiss;
            this.Sexe = sexe;
            this.Classe = classe;
            this.Option = option;
            this.Niveau = niveau;
            this.AnneeScol = anneeScol;
            this.NomPere = nomPere;
            this.NomMere = nomMere;
            this.Tel = tel;
            this.Adresse = adresse;
            this.Photo = photo;
        }
        public Elèves()
        {
        }
    }
}
