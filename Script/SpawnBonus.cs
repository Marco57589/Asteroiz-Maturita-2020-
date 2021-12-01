using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBonus : MonoBehaviour{
 
    public Vector3 center;
    public Vector3 size;    
    private GameObject aus;

    // Cura
    public GameObject cura;
    
    // Selettore (I_I , III)
    private bool maxUpgrade; //massimo upgrade raggiunto (blocco spawn)
    private int livSelettore;
    public GameObject s1;
    public GameObject s2;

    private float attesa;

    void Start(){//
        attesa=0.0f;
        livSelettore=1;
        maxUpgrade=false;                 
    }   

    private void spawnSelettore(){
        Vector3 pos = center+new Vector3(Random.Range(-125,125),Random.Range(-125,125),Random.Range(-125,125));   
        switch (livSelettore){
            case 1:           
                aus = Instantiate(s1,pos,Quaternion.identity);                
            break;
            case 2:
                aus = Instantiate(s2,pos,Quaternion.identity);         
            break;
        }
         
        if(livSelettore<3){
            livSelettore++; 
        }    

        aus.SetActive(true);             
        aus.name = "Selettore:"+livSelettore;
        aus.gameObject.tag="BonusSelettore"; 
    }

    private void spawnCura(){
        Vector3 pos = center+new Vector3(Random.Range(-125,125),Random.Range(-125,125),Random.Range(-125,125));
        aus = Instantiate(cura,pos,Quaternion.identity);  
        aus.SetActive(true);             
        aus.name = "Cura";
        aus.gameObject.tag="BonusCura"; 
    }

    private void spawnColpo(){
        Vector3 pos = center+new Vector3(Random.Range(-125,125),Random.Range(-125,125),Random.Range(-125,125));
    }

    void Update(){  
        if (Time.time > attesa ) {
            attesa = Time.time + 60; 
            if(livSelettore<3){                
                if(GameObject.FindGameObjectsWithTag("BonusSelettore").Length<1){  
                    spawnSelettore(); 
                }
            }else{
                if(GameObject.FindGameObjectsWithTag("BonusCura").Length<1){  
                    spawnCura(); 
                }
            }                           
        }     
    } 
    
      
}
