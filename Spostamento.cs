using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spostamento : MonoBehaviour
{
    public Vector3 puntoIniziale;
    public float speed = 0.001f;

    void Start(){        
    }

    void Update(){
        transform.position = Vector3.Lerp(transform.position, puntoIniziale, speed);
    }
}
