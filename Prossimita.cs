using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prossimita : MonoBehaviour{

    void OnCollisionEnter(Collision collision) { 
        
        if(collision.gameObject.tag=="Asteroide"){ 
            Handheld.Vibrate();
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());  
        } 
        if (collision.gameObject.tag == "Colpo") {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
        if (collision.gameObject.tag == "UpgradeSelettore") {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
        if (collision.gameObject.tag == "Cura") {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
            
    }

}
