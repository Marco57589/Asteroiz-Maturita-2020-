using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salute : MonoBehaviour{

    public Text Vita;
    public GameOver go;

    private int salute;

    void Start(){
        salute=4;  
        Vita.text="HP: "+salute;     
    }    

    public void setSalute(int s){
        salute+=s;
        Vita.text="HP: "+getSalute();
    }

    public int getSalute(){
        return salute;
    }

    private void converti(){
        string aus = Vita.text;
        aus = aus.Replace("HP: ","");
        salute = int.Parse(aus);        
    }

    public void colpito(){  
        converti();
        setSalute(-1);          
        if(getSalute()<1){          
            go.perso();          
        }
        Vita.text="HP: "+getSalute();
    }

    public void cura(){
        converti();
        if(getSalute()<5){
            setSalute(+1);
        } 
    }
    
}
