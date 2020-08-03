using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour{

    #region variables
    [SerializeField] public Input input;
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
    }

    private void OnDash(){
        controller.Move(direction * 1f);
    }

    private void OnHit(){
        if(left){   
            raquet.transform.Rotate(0,180,0,Space.Self);
            left = false;
            if(Vector3.Distance(raquet.transform.position,ball.transform.position)<1.5){
                ball.Hit(player);
                ball.GetComponent<Rigidbody>().AddForce(new Vector3(hitDir/3,0.4f,1f)*0.35f,ForceMode.Impulse);
            }
        }else{
            raquet.transform.Rotate(0,-180,0,Space.Self);
            left = true;
            if(Vector3.Distance(raquet.transform.position,ball.transform.position)<1.5){
                ball.Hit(player);
                ball.GetComponent<Rigidbody>().AddForce(new Vector3(hitDir/3,0.4f,1f)*0.35f,ForceMode.Impulse);
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
        
    }

    void Update(){
        direction = new Vector3(xAxis,0f,yAxis).normalized;
        if(direction.magnitude >= 0.1f){
            controller.Move(direction * speed * Time.deltaTime); 
        }
    }
}
