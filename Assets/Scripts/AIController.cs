using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AIController : MonoBehaviour{

    #region variables
    public int player;
    public CharacterController controller;
    public GameObject raquet;
    public Ball ball;
    public float speed = 5f;
    private float xAxis;
    private float yAxis;
    private float hitDir;
    private bool left = false;
    private Vector3 direction;
    #endregion

    private void hit(){
        if(left){   
            raquet.transform.Rotate(0,180,0,Space.Self);
            left = false;
            ball.Hit(player);
            ball.GetComponent<Rigidbody>().AddForce(new Vector3(0f,0.4f,-1f)*0.35f,ForceMode.Impulse);
        }else{
            raquet.transform.Rotate(0,-180,0,Space.Self);
            left = true;
            ball.Hit(player);
            ball.GetComponent<Rigidbody>().AddForce(new Vector3(0f,0.4f,-1f)*0.35f,ForceMode.Impulse);
        }
    }
    void Start(){
        
    }

    void Update(){
        direction = transform.position - ball.transform.position;
        direction = new Vector3(-direction.x, 0f, -direction.z);
        if(direction.magnitude >= 0.1f){
            controller.Move(direction * speed * Time.deltaTime); 
        }
        if(Vector3.Distance(raquet.transform.position,ball.transform.position)<1){
            hit();
        }
    }
}

