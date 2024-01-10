using System;

namespace Dentiste
{
    internal class EtatNify
    {
        string idDent;
        int etat;

        public string IdDent
        {
            get { return idDent; }
            set { idDent = value; }
        }

        public int Etat
        {
            get { return etat; }
            set { etat = value; }
        }
        public EtatNify(){}

        public EtatNify(string idDent, int etat)
        {
            this.idDent = idDent;
            this.etat = etat;
        }

public List<EtatNify> RearrangeOrder(List<EtatNify> dents)
{
    List<EtatNify> rearranged = new List<EtatNify>();
    int n = dents.Count;

    for (int i = 0; i < n / 2; i++)
    {
        rearranged.Add(dents[i]);
        rearranged.Add(dents[n - i - 1]);
    }

    if (n % 2 != 0)
    {
        rearranged.Add(dents[n / 2]);
    }

    return rearranged;
}







public List<EtatNify> GetCentral(List<EtatNify> etatNifys)
{
    Dent d  = new Dent();
    List<EtatNify> dentCentral = new List<EtatNify>();

    foreach (EtatNify etatnif in etatNifys)
    {
        Dent retrievedDent = d.GetDentByID(etatnif.IdDent);

        if (retrievedDent != null && retrievedDent.IsCentral())
        {
            dentCentral.Add(etatnif);
        }
    }
    List<EtatNify> dentCentralwithOrder =  RearrangeOrder(dentCentral);
    return dentCentralwithOrder;
}

public List<EtatNify> GetLateral(List<EtatNify> etatNifys)
{
    Dent d  = new Dent();
    List<EtatNify> dentLateral = new List<EtatNify>();

    foreach (EtatNify etatnif in etatNifys)
    {
        Dent retrievedDent = d.GetDentByID(etatnif.IdDent);

        if (retrievedDent != null && retrievedDent.IsLateral())
        {
            dentLateral.Add(etatnif);
        }
    }
    List<EtatNify> dentCentralwithOrder =  RearrangeOrder(dentLateral);
    return dentCentralwithOrder;
}




    }
}
