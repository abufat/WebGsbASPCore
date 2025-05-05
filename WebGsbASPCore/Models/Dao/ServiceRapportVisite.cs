using System;
using System.Data;
using WebGsbASPCore.Models.MesExceptions;
using WebGsbAspCore.Models.Persistance;
using WebGsbAspCore.Models.Metier;


namespace WebGsbAspCore.Models.Dao
{
    public class ServiceRapportVisite
    {
        public DataTable GetToutesLesVisites()
        {
            DataTable mesVisites;
            Serreurs er = new Serreurs("Erreur sur lecture des rapports de visite.", "RapportVisite.getVisites");
            try
            {
                string mysql = "SELECT * FROM rapport_visite ";
                mysql += "JOIN praticien ON praticien.id_praticien = rapport_visite.id_praticien ";
                mysql += "JOIN offrir ON offrir.id_rapport = rapport_visite.id_rapport ";
                mysql += "JOIN medicament ON medicament.id_medicament = offrir.id_medicament ";
                mysql += "ORDER BY rapport_visite.id_rapport";

                mesVisites = DBInterface.Lecture(mysql, er);

                return mesVisites;
            }
            catch (MonException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        public static DataTable GetTousLesIdRapport()
        {
            string sql = "SELECT DISTINCT id_rapport FROM rapport_visite ORDER BY id_rapport";
            Serreurs er = new Serreurs("Erreur Rapports", "ServiceRapportVisite.GetTousLesTitres()");
            return DBInterface.Lecture(sql, er);
        }
    }


    /// <summary>
    /// /////
    /// </summary>
    /// <param name="id_med"></param>
    /// <returns></returns>
    /// <exception cref="MonException"></exception>
}

