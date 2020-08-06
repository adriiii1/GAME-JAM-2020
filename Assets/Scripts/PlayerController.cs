using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour{

    #region variables
    [SerializeField] public Input input;
    public Animator animator;
    public int player;
    public CharacterController controller;
    public GameObject raquet;
    public Ball ball;
    public float speed = 5f;
    private float xAxis;
    private float yAxis;
    private float hitDir;
    private bool left = false;
    private bool canDash = true;
    private bool canRewind = false;
    private Vector3 direction;
    #endregion

    IEnumerator CountdownTimer(){
        yield return new WaitForSeconds(5);
        canDash = true;
    }

    IEnumerator CountdownRewindTimer(){
        yield return new WaitForSeconds(15);
        canRewind= true;
    }

    private void Awake(){
        input = new Input();
        
        input.Player.MoveX.performed += ctx => xAxis = ctx.ReadValue<float>();
        input.Player.MoveY.performed += ctx => yAxis = ctx.ReadValue<float>();
        input.Player.MoveX.canceled += ctx => xAxis = 0f;
        input.Player.MoveY.canceled += ctx => yAxis = 0f;
        input.Player.Dash.performed += ctx => OnDash();
        input.Player.Hit.performed += ctx => OnHit();
        input.Player.HitDirection.performed += ctx => hitDir = ctx.ReadValue<float>();
        input.Player.HitDirection.canceled += ctx => hitDir = 0f;
        input.Player.Rewind.performed += ctx => OnRewind();
        input.Player.Rewind.canceled += ctx => OnRewindStop();
    }

    private void OnRewind(){
        if(canRewind){
            ball.StartRewind();
        }
    }
    private void OnRewindStop(){
        ball.RewindStop();
        canRewind = false;
        StartCoroutine(CountdownRewindTimer());
    }

    private void OnDash(){
        if(canDash){
           controller.Move(direction * 1f);
           canDash = false; 
           StartCoroutine(CountdownTimer());
        }
    }

    private void OnHit(){
        animator.SetTrigger("hit");
        if(left){   
            left = false;
            if(Vector3.Distance(raquet.transform.position,ball.transform.position)<1.5){
                Vector3 ballDir = new Vector3(hitDir/3,0.4f,1f);
                ball.Hit(player, ballDir);
            }
        }else{
            left = true;
            if(Vector3.Distance(raquet.transform.position,ball.transform.position)<1.5){
                Vector3 ballDir = new Vector3(hitDir/3,0.4f,1f);
                ball.Hit(player, ballDir);
            }
        }
    }
    void OnEnable() {
        input.Player.Enable();
    }
    void OnDisable() {
        input.Player.Disable();
    }

    void Start(){
        StartCoroutine(CountdownRewindTimer());
    }

    void Update(){
        direction = new Vector3(xAxis,0f,yAxis).normalized;
        animator.SetFloat("inputX",xAxis);
        animator.SetFloat("inputZ",yAxis);
        if(direction.magnitude >= 0.1f){
            controller.Move(direction * speed * Time.deltaTime); 
        }
    }
}
