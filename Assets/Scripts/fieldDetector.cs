using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldDetector : MonoBehaviour{
    public CanchaController cancha1;
    public CanchaController cancha2;
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Ball"){
            cancha1.resetBounces();
            cancha2.resetBounces();
        }
    }
}
