using System.IO;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour{
     
    [SerializeField] private List<int> punteggi;
    public Punteggio p;
    private int score;

    void Start(){ 
        Leggi();          
    }
     
    public void Scrivi(){   
        string url = Application.persistentDataPath + "/Scoreboard.dat";
        FileStream file;
        score = p.getPunteggio();
  
        punteggi.Add(score);
      
        if(File.Exists(url)) 
            file = File.OpenWrite(url);
        else 
            file = File.Create(url);
 
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, punteggi);
        file.Close();
    }
     
    public void Leggi(){
        string url = Application.persistentDataPath + "/Scoreboard.dat";
        FileStream file;
     
        if(File.Exists(url)) 
            file = File.OpenRead(url);
        else{
            Debug.LogError("File not found");
            return;
        }
     
        BinaryFormatter bf = new BinaryFormatter();
        List<int> aus = (List<int>) bf.Deserialize(file);
        punteggi=aus;

        file.Close();     
    }   

    public void aggiungiPunteggio(){
        Leggi();      
        Scrivi();
    }
}

