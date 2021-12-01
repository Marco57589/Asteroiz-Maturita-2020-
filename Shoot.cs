using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shoot : MonoBehaviour{

    public GameObject nave;

    public GameObject Colpo1;
    public GameObject Colpo2;
    public GameObject Colpo3;
    public GameObject Colpo4;
    public GameObject colpo;

    public Transform posNave;
    public Transform left;
    public Transform right;

    public int upgrade;
    public int tipo; 
   
    void Start(){
        upgrade=2;
    }
    
    private float attesa = 0.0f;

    void Update(){ 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName ("Gioco")){ 
            if (Input.GetKeyDown("t")){                
                spara(tipo);
            }  
            /*    
            if (Time.time > attesa ) {
                attesa = Time.time + 0.5f;
                spara(tipo);            
            }

            if (Input.GetKeyDown("y")){                
                upgrade++;
                if(upgrade>3){
                    upgrade=1;
                }
            } 
             if (Input.GetKeyDown("Joystick1Button4")){                
            spara(tipo);
        } 
        if (Input.GetKeyDown("Joystick1Button5")){                
            upgrade++;
            if(upgrade>3){
                upgrade=1;
            }
        } 
            */
            if(Input.GetKeyDown(KeyCode.Joystick1Button4))
                spara(tipo);
            
            if (Input.GetKeyDown(KeyCode.Joystick1Button7)){                
                upgrade++;
                if(upgrade>3){
                    upgrade=1;
                }
            } 
            if (Input.GetKeyDown(KeyCode.Joystick1Button0)){                
                tipo++;
                if(tipo>3){
                    tipo=0;
                }
            } 

            
        } 
    }   

    /*
    public void detectPressedKeyOrButton(){

        foreach(KeyCode kcode in Enum.GetValues(typeof(KeyCode))){
            if (Input.GetKeyDown(kcode))
                txt.text="Tasto: " +kcode; 
            }
    }
    */

    void spara(int tipo){
        
        switch(tipo){
            case 0:
                if(upgrade==1)              
                    colpoSingolo(Colpo1);
                else if(upgrade==2)
                    colpoDoppio(Colpo1);
                else if(upgrade==3){
                    colpoSingolo(Colpo1);
                    colpoDoppio(Colpo1);
                }
            break;
            case 1:
                if(upgrade==1)              
                    colpoSingolo(Colpo2);
                else if(upgrade==2)
                    colpoDoppio(Colpo2);                
                else if(upgrade==3){
                    colpoSingolo(Colpo2);
                    colpoDoppio(Colpo2);
                }
            break;
            case 2:
                if(upgrade==1)              
                    colpoSingolo(Colpo3);
                else if(upgrade==2)
                    colpoDoppio(Colpo3);                
                else if(upgrade==3){
                    colpoSingolo(Colpo3);
                    colpoDoppio(Colpo3);
                }
            break;
            case 3:
                if(upgrade==1)              
                    colpoSingolo(Colpo4);
                else if(upgrade==2)
                    colpoDoppio(Colpo4);                
                else if(upgrade==3){
                    colpoSingolo(Colpo4);
                    colpoDoppio(Colpo4);
                }            
            break;            
        }        
    } 

    void colpoSingolo(GameObject tipo){        
        
        colpo = Instantiate(tipo, posNave.position, posNave.rotation);
        colpo.SetActive(true);  
        colpo.GetComponent<Rigidbody>().AddForce(-colpo.transform.up * 2500);
        
    }
    void colpoDoppio(GameObject tipo){

        colpo = Instantiate(tipo, left.position, posNave.rotation);
        colpo.SetActive(true);  
        colpo.GetComponent<Rigidbody>().AddForce(-colpo.transform.up * 2500);

        colpo = Instantiate(tipo, right.position, posNave.rotation);
        colpo.SetActive(true);  
        colpo.GetComponent<Rigidbody>().AddForce(-colpo.transform.up * 2500);

    }



}
