using System;

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
    // importer les classes planning, interloctueur et type rdv
    private Planning planning;
    private Interlocuteur interlocuteur;
    private TypeRdv typeRdv;

    public RendezVous()
	{

	}

    public DateTime GetdateRdv()
    {
        return this.dateRdv;
    }

    public void SetdateRdv(DateTime uneDateRdv)
    {
        this.dateRdv = uneDateRdv;
    }

    public DateTime GetHeureDebut()
    {
        return this.heureDebut;
    }

    public void SetHeureDebut(DateTime uneHeureDebut)
    {
        this.heureDebut = uneHeureDebut;
    }

    public DateTime GetHeureFin()
    {
        return this.heureFin;
    }

    public void SetHeureFin(DateTime uneHeureFin)
    {
        this.heureFin = uneHeureFin;
    }

    public string GetAdresseDerogatoire()
    {
        return this.adresseDerogatoire;
    }

    public void SetAdresseDerogatoire(string uneAdresseDerogatoire)
    {
        this.adresseDerogatoire = uneAdresseDerogatoire;
    }

    public string GetVilleDerogatoire()
    {
        return villeDerogatoire;
    }

    public void SetVilleDerogatoire(string uneVilleDerogatoire)
    {
        this.villeDerogatoire = uneVilleDerogatoire;
    }

    public string GetInfoDerogatoire()
    {
        return this.infoDerogatoire;
    }

    public void SetInfoDerogatoire(string uneInfoDerogatoire)
    {
        this.infoDerogatoire = uneInfoDerogatoire;
    }

    public int GetIdRdv()
    {
        return this.idRdv;
    }

    public void SetIdRdv ( int unIdRdv)
    {
        this.idRdv = unIdRdv;
    }

    public int GetCodeEntreeDerogatoire()
    {
        return this.codeEntreeDerogatoire;
    }

    public void SetCodeEntreeDerogatoire(int unCodeEntreeDerogatoire)
    {
        this.codeEntreeDerogatoire = unCodeEntreeDerogatoire;
    }
   
    public Interlocuteur GetInterlocuteur()
    {   
        return this.interlocuteur;  
    }

	public void SetInterlocuteur(Interlocuteur unInterlocuteur)
	{
		this.interlocuteur = unInterlocuteur;
	}

    public Planning GetPlanning()
    {
        return this.planning;
    }

	public void SetPlanning(Planning unPlanning)
	{
		this.planning = unPlanning;
	}

    public TypePlanning GetTypePlanning()
    {
        return this.typeRdv;
    }

	public void SetTypeRDV(TypeRdv unTypeRDV)
	{
		this.typeRdv = unTypeRDV;
	}
}
