using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour{

    public GameObject h_vita;
    public GameObject h_score;
    public GameObject nave;
    public GameObject h1;
    public Record r;

    public Text go;

    void Start(){ 
        go.text="";             
    }

    public void perso(){
        go.text="GAME OVER";
        r.aggiungiPunteggio();
        StartCoroutine(finePartita());         
    }

    private IEnumerator finePartita(){          
        h_vita.SetActive(false);
        h_score.SetActive(false);    
        h1.SetActive(false);  
        nave.SetActive(false); 
        gameObject.SetActive(true);
        yield return new WaitForSeconds(5); 

        if(XRSettings.enabled){
            SceneManager.LoadScene("Home");   
        }else{
            SceneManager.LoadScene("Home2D");   
        }                           
    }
	
}
