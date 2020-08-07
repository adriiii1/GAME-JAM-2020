using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMenuRotater : MonoBehaviour{
    void Update(){
        this.transform.Rotate(new Vector3(0f,0.02f,0f),Space.Self);   
    }
}
