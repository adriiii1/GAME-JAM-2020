using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AIController : MonoBehaviour{

    #region variables
    public int player;
    public CharacterController controller;
    public GameObject raquet;
    public Animator animator;
    public Ball ball;
    public float speed = 5f;
    private float xAxis;
    private float yAxis;
    private float hitDir;
    private bool left = false;
    private bool canRewind = false;
    private Vector3 direction;
    #endregion

    private void hit(){
        animator.SetTrigger("hit");
        float dir = Random.Range(-1f,1f);
        if(left){
            left = false;
            Vector3 ballDir = new Vector3(dir,0.4f,-1f);
            ball.Hit(player , ballDir);
        }else{
            left = true;
            Vector3 ballDir = new Vector3(dir,0.4f,-1f);
            ball.Hit(player , ballDir);
        }
    }
    void Start(){
        
    }

    void Update(){
        direction = transform.position - ball.transform.position;
        direction = new Vector3(-direction.x, 0f, 0f);
        xAxis = -direction.x;
        animator.SetFloat("inputX",xAxis);
        if(direction.magnitude >= 0.1f){
            controller.Move(direction * speed * Time.deltaTime); 
        }
        if(Vector3.Distance(raquet.transform.position,ball.transform.position)<1){
            hit();
        }
    }
}

