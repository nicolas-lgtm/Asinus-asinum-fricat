using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
//using System.Text.Json;
//using Newtonsoft.Json;

using UnityEngine;

[Serializable]
public class ListeDeMot

{
    public string titre, theme, commentaire;

    public List<Mot> mots = new List<Mot>();

    public ListeDeMot(string a_titre, string a_theme, string a_commentaire)
    {
        titre = a_titre;
        theme = a_theme;
        commentaire = a_commentaire;


    }

    public void JsonSauvegarde()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true
        };

        string json = JsonSerializer.Serialize(this, options);
        string directory = GeneralManager.directory;

        if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);

        File.WriteAllText(directory + titre + ".txt", json);

        Debug.Log(directory);
        Debug.Log(json);

        //ListeDeMot liste2 = JsonSerializer.Deserialize<ListeDeMot>(json);
        //Debug.Log(liste2.mots.Count);
        //liste2.DebugAfficherListeDeMots();
    }

    public void DebugAfficherListeDeMots()
    {
        foreach (Mot mot in mots) mot.DebugAfficherMot();
    }
}
