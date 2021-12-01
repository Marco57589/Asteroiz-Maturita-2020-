using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisione : MonoBehaviour{

    public GameObject esplosioneObj;
    private GameObject esplosione;
    public Transform posizione;

    void Start(){        
    }

    void Update(){  
       
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag=="Colpo"){                
            Destroy(collision.gameObject);
            Destroy(gameObject);

            esplosione = Instantiate(esplosioneObj, posizione.position, posizione.rotation);     
            esplosione.AddComponent<AutoDistruzione>();     
        }

        if (collision.gameObject.tag == "Confine") {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }        
    }

}
