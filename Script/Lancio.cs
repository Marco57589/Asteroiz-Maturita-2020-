using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class Lancio : MonoBehaviour{    

    public Button vr;
    public Button virtuale;

    void Start(){      
        XRSettings.enabled = false; 
        Button b1 = vr.GetComponent<Button>();
        Button b2 = virtuale.GetComponent<Button>();
        b1.onClick.AddListener(vrOn);
        b2.onClick.AddListener(vrOff);
    }

    private void modalita(int mode){
        if(mode==1){
            XRSettings.enabled = enabled;
            lancio(1);
        }else{
            XRSettings.enabled = false;
            lancio(2);
        }        
    }

    private void vrOn(){
        modalita(1);
    }
    private void vrOff(){
        modalita(2);
    }

    private void lancio(int mode){
        if(mode==1){
            SceneManager.LoadScene("Home"); 
        }else{
            SceneManager.LoadScene("Home2D"); 
        }
         
    }
}
