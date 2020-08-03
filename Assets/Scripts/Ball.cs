using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{
    #region variables
    public GameManager manager;
    private int player;
    private Vector3[] positions;
    #endregion
  
    public void Hit(int player){
        this.player = player;
        this.transform.position = new Vector3(this.transform.position.x,1.5f,this.transform.position.z);
        GetComponent<Rigidbody>().useGravity = true;
        manager.lastPlayerHit(player);
    }

    public int getPlayer(){
        return player;
    }
}
