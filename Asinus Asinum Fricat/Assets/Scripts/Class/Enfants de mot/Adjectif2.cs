using static GeneralManager;

public class Adjectif2 : Mot
{
    public Adjectif2(string a_masculin, string a_feminin, string a_neutre, string a_genitif, string a_traduction, string a_commentaire, bool version)
        : base(a_traduction, a_commentaire, version)
    {
        champs.Insert(0, new Champ(Champs.Masculin, a_masculin));
        champs.Insert(1, new Champ(Champs.Feminin, a_feminin));
        champs.Insert(2, new Champ(Champs.Neutre, a_neutre));
        champs.Insert(3, new Champ(Champs.Genitif, a_genitif));

        type = TypeDeMot.Adjectif2;
    }
}
