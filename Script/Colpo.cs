using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colpo : MonoBehaviour{

    public int danno;
    int p;
    
    void Start(){        
        GameObject giocatore = GameObject.Find("nave");
        int p = giocatore.GetComponent<Nave>().punteggio;
    }

    void Update(){        
    }

    void OnCollisionEnter(Collision collision) {

        if(collision.gameObject.tag=="Confine"){
            Destroy(gameObject);
        }  
        if(collision.gameObject.tag=="Asteroide"){
            p++;
        }      
    }
}
