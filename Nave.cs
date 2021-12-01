using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nave : MonoBehaviour{

    public Text Vita;
    public Text Score;

    public int hp;
    public int punteggio;

    void Start(){
        Vita.text="HP: " +hp;
    }

    void Update(){
        if(hp<=0){
            Vita.text="HP: MORTO";
        }
    }

    void OnCollisionEnter(Collision collision) {

        if(collision.gameObject.tag=="Asteroide"){
            Destroy(collision.gameObject);
            hp--;
            Vita.text="HP: " +hp;
        }
        
        if (collision.gameObject.tag == "Colpo") {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
        
    }
}
