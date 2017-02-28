using System;
using System.Collections.Generic;
using System.Data;
using BelleTable.InterlocuteurClass;
using BelleTable.DatabaseConnectClass;
using BelleTable.PlanningClass;
using BelleTable.TypeRDVClass;

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

        public Planning GetPlanning()
        {
            return planning;
        }

        public void SetPlanning(Planning unPlanning)
        {
            planning = unPlanning;
        }

           public TypePlanning GetTypePlanning()
           {
               return typeRdv;
           }

           public void SetTypeRDV(TypeRDV unTypeRDV)
           {
               typeRdv = unTypeRDV;
           }


           // importer la classe connexion et planning

           public List<List<String>> ChargerLesRendezVousPlanning(maConnexion, Planning planning) 
           {
           List<String> unRendezVous = new List<String>();
           List<String> lesRendezVous = new List<String>();

            DataTable dt = maConnexion.Select("SELECT * FROM RENDEZVOUS WHERE idPlanning="+planning.getId());

           foreach (DataRow row in dt.Rows)
           {
               unRendezVous.Add(row.ToString());
               lesRendezVous.Add(unRendezVous);
               unRendezVous = new List<String>();
           }

           return lesRendezVous;
           }

           public List<List<String>> ChargerLesRendezVousCommercial(Connexion maConnexion, Commercial commercial) 
           {
           return ChargerLesRendezVousPlanning( maConnexion, commercial.getPlanning());
           }


           public void AjouterUnRendezVous(RendezVous unRdv)
           {
           //mysql.Command("INSERT INTO RDV (date_rdv, heure_debut, heure_fin, adresseDerogatoire, villeDerogatoire,  codeEntreeDerogatoire, infoDerogatoire, id_interlocuteur, id_type_rdv, idPlanning) VALUES (this.dateRdv, 
           // this.heureDebut, this.heureFin, this.adresseDerogatoire, this.villeDerogatoire, this.codeEntreeDerogatoire, this.infoDerogatoire, this.id_interlocuteur, this.id_type_rdv, this.idPlanning)");
           }

           public void SupprimerUnRendezVous(int unid_rdv)
           {
           //mysql.Command("DELETE FROM RDV WHERE id_rdv=@unid_rdv");
           }

           public DataTable chargerUnRendezVous(int idRdv)
           {
              // DataTable LeRDV = DatabaseConnect.Select("SELECT * FROM RDV WHERE id_rdv=@idRdv");

               return LeRDV;
           }
       

    }
}    