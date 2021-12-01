using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour{

    public Vector3 center;
    public Vector3 size;    
    public GameObject clone;
    public GameObject asteroide;
    public GameObject asteroide1;
    public GameObject asteroide2;

    private int n;

    private float attesa = 0.0f;
    public float frequenza = 1f;
    public bool controller=false;

    void Start(){
        for(int k=0;k<50;k++){
            SpawnAsteroide(false);        
        }        
    }   


    void Update(){  
        if(Input.GetKey(KeyCode.Q)){
            SpawnAsteroide(true);
        }       

        if (Time.time > attesa ) {
            attesa = Time.time + 3;                       
            if(n<70){
                SpawnAsteroide(true); 
            }
        }        
    }    
    
    public void SpawnAsteroide(bool finti){
        Vector3 pos = center+new Vector3(Random.Range(-125,125),Random.Range(-125,125),Random.Range(-125,125));
        int i=Random.Range(0,3);
       
        switch (i){
            case 0:
                clone = Instantiate(asteroide,pos,Quaternion.identity);                
            break;
            case 1:
                clone = Instantiate(asteroide1,pos,Quaternion.identity);         
            break;
            case 2:
                clone = Instantiate(asteroide2,pos,Quaternion.identity);                                 
            break;            
        } 
       
        clone.SetActive(true);        
        ridimensiona(clone);
        clone.name = "Asteroide[Tipo"+i+"]n:"+n;  
        clone.gameObject.tag="Asteroide"; 
        n++;        

        if(finti){
            clone.AddComponent<Spostamento>();
        }
   }  

   public GameObject ridimensiona(GameObject asteroideAUS){
        Vector3 nuovaDimensione = asteroideAUS.transform.localScale;
        float dimensione = Random.Range (0.5f, 5f);
        nuovaDimensione.x = dimensione;
        nuovaDimensione.y = dimensione;
        nuovaDimensione.z = dimensione;
        asteroideAUS.transform.localScale = nuovaDimensione;
        return asteroideAUS;
   }
}
