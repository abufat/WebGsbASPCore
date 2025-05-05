using System;
using Microsoft.AspNetCore.Mvc;

namespace WebGsbAspCore.Models.Metier
{
    public class RapportVisite
    {
        private int id_rapport;
        private int id_praticien;
        private int id_visiteur;
        private DateTime date_rapport;
        private string bilan;
        private string motif;

        public int Id_rapport { get => id_rapport; set => id_rapport = value; }

        public int Id_praticien { get => id_praticien; set => id_praticien = value; }

        public int Id_visiteur { get => id_visiteur; set => id_visiteur = value; }

        public DateTime Date_rapport { get => date_rapport; set => date_rapport = value; }

        public string Bilan { get => bilan; set => bilan = value; }

        public string Motif { get => motif; set => motif = value; }

    }
}
