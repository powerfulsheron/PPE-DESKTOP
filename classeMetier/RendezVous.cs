using System;
using System.Collections.Generic;
using System.Data;
using BelleTable.InterlocuteurClass;
using BelleTable.DatabaseConnectClass;
using BelleTable.PlanningClass;
using BelleTable.TypeRDVClass;
using BelleTable.UtilisateurClass;

namespace BelleTable.RendezVousClass
{

    public class RendezVous
    {
        private int idRdv;
        private int codeEntreeDerogatoire;

        private DateTime dateRdv;
        private DateTime heureDebut;
        private DateTime heureFin;

        private string adresseDerogatoire;
        private string villeDerogatoire;
        private string infoDerogatoire;
        private Planning planning;
        private Interlocuteur interlocuteur;
        private TypeRDV typeRdv;
        private DatabaseConnect maDatabase;

        public RendezVous()
        {
           
        }

        public DateTime GetdateRdv()
        {
            return dateRdv;
        }

        public void SetdateRdv(DateTime uneDateRdv)
        {
            dateRdv = uneDateRdv;
        }

        public DateTime GetHeureDebut()
        {
            return heureDebut;
        }

        public void SetHeureDebut(DateTime uneHeureDebut)
        {
            heureDebut = uneHeureDebut;
        }

        public DateTime GetHeureFin()
        {
            return heureFin;
        }

        public void SetHeureFin(DateTime uneHeureFin)
        {
            heureFin = uneHeureFin;
        }

        public string GetAdresseDerogatoire()
        {
            return adresseDerogatoire;
        }

        public void SetAdresseDerogatoire(string uneAdresseDerogatoire)
        {
            adresseDerogatoire = uneAdresseDerogatoire;
        }

        public string GetVilleDerogatoire()
        {
            return villeDerogatoire;
        }

        public void SetVilleDerogatoire(string uneVilleDerogatoire)
        {
            villeDerogatoire = uneVilleDerogatoire;
        }

        public string GetInfoDerogatoire()
        {
            return infoDerogatoire;
        }

        public void SetInfoDerogatoire(string uneInfoDerogatoire)
        {
            infoDerogatoire = uneInfoDerogatoire;
        }

        public int GetIdRdv()
        {
            return idRdv;
        }

        public void SetIdRdv(int unIdRdv)
        {
            idRdv = unIdRdv;
        }

        public int GetCodeEntreeDerogatoire()
        {
            return codeEntreeDerogatoire;
        }

        public void SetCodeEntreeDerogatoire(int unCodeEntreeDerogatoire)
        {
            codeEntreeDerogatoire = unCodeEntreeDerogatoire;
        }

        public Interlocuteur GetInterlocuteur()
        {
            return interlocuteur;
        }

        public void SetInterlocuteur(Interlocuteur unInterlocuteur)
        {
            interlocuteur = unInterlocuteur;
        }



        public void SetTypeRDV(TypeRDV unTypeRDV)
        {
            typeRdv = unTypeRDV;
        }


        /*

        public List<String> ChargerLesRendezVousPlanning(Planning planning) 
        {
        List<String> unRendezVous = new List<String>();
        List<String> lesRendezVous = new List<String>();

        DataTable dt = maDatabase.Select("SELECT * FROM RENDEZVOUS WHERE idPlanning="+planning.GetidPlanning());

        foreach (DataRow row in dt.Rows)
        {
            unRendezVous.Add(row.ToString());
            lesRendezVous.Add(unRendezVous.ToString());
            unRendezVous = new List<String>();
        }

        return lesRendezVous;
        }
        */

        /*
        public List<List<String>> ChargerLesRendezVousCommercial(Utilisateur unCommercial) 
        {
            return ChargerLesRendezVousPlanning(unCommercial.getPlanning());
        }
        */

        public void AjouterUnRendezVous(RendezVous unRdv)
        {
            maDatabase.Insert("INSERT INTO RDV (date_rdv, heure_debut, heure_fin, adresseDerogatoire, villeDerogatoire,  codeEntreeDerogatoire, infoDerogatoire, id_interlocuteur, id_type_rdv, idPlanning) VALUES (this.dateRdv," +
            "@heureDebut, @heureFin, @adresseDerogatoire, @villeDerogatoire, @codeEntreeDerogatoire, @infoDerogatoire, @id_interlocuteur, @id_type_rdv, @idPlanning)");
        }

        public void SupprimerUnRendezVous(int unid_rdv)
        {
        maDatabase.Delete("DELETE FROM RDV WHERE id_rdv=@unid_rdv");
        }

        public DataTable chargerUnRendezVous(int idRdv)
        {
            DataTable LeRDV = maDatabase.Select("SELECT * FROM RDV WHERE id_rdv=@idRdv");
            return LeRDV;
        }
       

    }
}    