using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{
    #region variables
    public GameManager manager;
    public Rigidbody rigidbody;
    private int lastPlayer = 0;
    private Vector3[] positions = new Vector3[0];
    #endregion

    /*IEnumerator recordPositions(){
        positions[0] = transform.position;
        yield return new WaitForSeconds(0.2);
        positions[1] = transform.position;
        yield return new WaitForSeconds(0.2);
        positions[2] = transform.position;
        yield return new WaitForSeconds(0.2);
        positions[3] = transform.position;
        yield return new WaitForSeconds(0.2);
        positions[4] = transform.position;
        yield return new WaitForSeconds(0.2);
    }*/
  
    public void Hit(int player, Vector3 direction){
        if(player != lastPlayer){
            this.lastPlayer = player;
            this.transform.position = new Vector3(this.transform.position.x,1.5f,this.transform.position.z);
            rigidbody.velocity = Vector3.zero;
            rigidbody.useGravity = true;
            rigidbody.isKinematic = false;
            rigidbody.AddForce(direction*15f,ForceMode.Force);
            GetComponent<AudioSource>().Play();
            manager.lastPlayerHit(player);
        }
    }

    public int getPlayer(){
        return lastPlayer;
    }

    public void resetPlayer(){
        lastPlayer = 0;
    }
}
