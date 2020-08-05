using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanchaController : MonoBehaviour{
    public int cancha;
    public int otherCancha;
    public GameManager manager;
    private int numBounces = 0;
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Ball"){
            if(other.GetComponent<Ball>().getPlayer() == cancha){
                manager.addPointsP(otherCancha);
            }
            if(other.GetComponent<Ball>().getPlayer() == otherCancha){
                numBounces++;
                if(numBounces == 2){
                    manager.addPointsP(otherCancha);
                    numBounces = 0;
                }
            }
        }
    }

    public void resetBounces(){
        numBounces = 0;
    }
}
