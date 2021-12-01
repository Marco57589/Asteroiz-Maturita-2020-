using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisioneNave : MonoBehaviour{

    void Start(){        
    }


    void Update(){        
    }

    void OnCollisionEnter(Collision collision) {

        if(collision.gameObject.tag=="Asteroide"){
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Colpo") {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
        
    }
}
