using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballProjector : MonoBehaviour{
    public Ball ball;
    public Light light;
    void Update(){
        this.transform.position = new Vector3(ball.transform.position.x,ball.transform.position.y + 1,ball.transform.position.z);
        if(ball.lastPlayer == 1){
            light.color = Color.blue;
        }else if(ball.lastPlayer == 2){
            light.color = Color.red;
        }else{
            light.color = Color.green;
        }
    }
}
