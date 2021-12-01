using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDistruzione : MonoBehaviour{

    public int timer;
    
    void Start(){
        timer=3;
    }

    void Update(){
        Destroy(gameObject, timer); 
    }
}
