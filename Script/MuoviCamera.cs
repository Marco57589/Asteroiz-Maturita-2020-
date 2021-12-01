using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuoviCamera : MonoBehaviour{

    private float speed;

    void Start(){
        speed = 0.1F;
    }
    void Update() {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Rotate(-touchDeltaPosition.y * speed, touchDeltaPosition.x * speed, 0);
        }
    }
}
