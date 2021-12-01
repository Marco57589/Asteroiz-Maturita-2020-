using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punteggio : MonoBehaviour{

    public Text Score;
    private int punteggio;

    void Start(){
        punteggio = 0;  
        Score.text="SCORE: " +punteggio;      
    }
  
    void Update(){        
    }

    public int getPunteggio(){
        return punteggio;
    }

    private void converti(){
        string aus = Score.text;
        aus = aus.Replace("SCORE: ","");
        punteggio = int.Parse(aus);        
    }

    public void incrementa(){  
        converti();
        punteggio++;      
        Score.text="SCORE: "+punteggio;
    }
}
