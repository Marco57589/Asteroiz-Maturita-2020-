using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;


public class DisplayRecord : MonoBehaviour{

    void Start(){        
        Leggi();        
    }   
     
    public void Leggi(){
        string url = Application.persistentDataPath + "/Scoreboard.dat";
        FileStream file;
     
        if(File.Exists(url)) 
            file = File.OpenRead(url);
        else{
            Debug.LogError("File non trovato");
            return;
        }
     
        BinaryFormatter bf = new BinaryFormatter();
        List<int> aus = (List<int>) bf.Deserialize(file);

        aus.Sort();
        aus.Reverse();
        
        int i;
        Text t;   
      
        for(i=0;i<6;i++){     
            t = GameObject.Find("rec"+(i+1)).GetComponent<Text>();
            if(i<aus.Count){                
                t.text= +(i+1)+") "+aus[i];
            }else{
                t.text=+(i+1)+") N/A";
            }
        }
        file.Close();     
    } 
}

