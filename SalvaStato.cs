using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalvaStato : MonoBehaviour{

    void Awake(){

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Musica");
        if (objs.Length>1){
            Destroy(objs[0]);
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
