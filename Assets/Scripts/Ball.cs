using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{
    #region variables
    public GameManager manager;
    public Rigidbody rigidbody;
    private int lastPlayer = 0;
    private Vector3 pos1 = new Vector3(0f,1.5f,-12f);
    private Vector3 pos2 = new Vector3(0f,1.5f,12f);
    private List<Vector3> positions;
    private bool rewind = false;
    private bool record = false;
    #endregion
  
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
            if(player == 1){
                record = true;
            }else{
                record = false;
                positions.Clear();
            }
        }
    }

    private void Start() {
        positions = new List<Vector3>();
    }

    public void StartRewind(){
        lastPlayer = 0;
        rewind = true;
        rigidbody.isKinematic = true;
    }
    public void Rewind(){
        if(positions.Count > 0){
            transform.position = positions[0];
            positions.RemoveAt(0);
        }else{
            RewindStop();
        }
    }

    public void RewindStop(){
        rewind = false;
        rigidbody.isKinematic = false;
    }

    public int getPlayer(){
        return lastPlayer;
    }

    public void resetPlayer(){
        lastPlayer = 0;
    }

    public void resetBall(int player){
        if(player == 1){
            transform.position = pos1;
            rigidbody.useGravity = false;
            rigidbody.isKinematic = true;
        }else{
            transform.position = pos2;
            rigidbody.useGravity = false;
            rigidbody.isKinematic = true;
        }
        resetPlayer();
        rigidbody.isKinematic = false;
    }

    private void FixedUpdate() {
        if(rewind){
            Rewind();
        }else if(record){
            Record();
        }
    }

    private void Record(){
        positions.Insert(0, transform.position);
    }
}
