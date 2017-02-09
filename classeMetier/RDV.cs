using System;

public class RDV
{
    private int idRDV;
    private int codeEntreeDerogatoire;
    
    private DateTime dateRDV;
    private DateTime heureDebut;
    private DateTime heureFin;

    private string adresseDerogatoire;
    private string villeDerogatoire;
    private string infoDerogatoire;

    public RDV()
	{

	}

    /**setter**/
    public void SetdateRDV(DateTime unedateRDV)
    {
        dateRDV = unedateRDV;
    }
    public void SetheureDebut(DateTime uneheureDebut)
    {
        heureDebut = uneheureDebut;
    }
    public void SetheureFin(DateTime uneheureFin)
    {
        heureFin = uneheureFin;
    }
    public void SetadresseDerogatoire(string uneadresseDerogatoire)
    {
        adresseDerogatoire = uneadresseDerogatoire;
    }
    public void SetvilleDerogatoire(string unevilleDerogatoire)
    {
        villeDerogatoire = unevilleDerogatoire;
    }
    public void SetinfoDerogatoire(string uneinfoDerogatoire)
    {
        infoDerogatoire = uneinfoDerogatoire;
    }
    public void SetidRDV ( int uneidRDV)
    {
        idRDV = uneidRDV;
    }
    public void SetcodeEntreeDerogatoire(int uncodeEntreeDerogatoire)
    {
        codeEntreeDerogatoire = uncodeEntreeDerogatoire;
    }

    /**getter**/
    public DateTime GetdateRDV()
    {
        return dateRDV;
    }
    public DateTime GetheureDebut()
    {
        return heureDebut;
    }
    public DateTime GetheureFin()
    {
        return heureFin;
    }
    public string GetadresseDerogatoire()
    {
        return adresseDerogatoire;
    }
    public string GetvilleDerogatoire()
    {
        return villeDerogatoire;
    }
    public string GetinfoDerogatoire()
    {
        return infoDerogatoire;
    }
    public int GetidRDV()
    {
        return idRDV;
    }
    public int GetcodeEntreeDerogatoire()
    {
        return codeEntreeDerogatoire;
    }
    public void GetListPlanning()
    {
    	//appelle la collection de la classe planning
    }
    public void GetListInterlocuteur()
    {
    	//appelle la collection de la classe interlocuteur
    }
    public void GetListTypeRDV()
    {
    	//appelle la collection de la classe typeRDV
    }
}
