using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour{

    #region 
        public Camera camera;
        public Rigidbody rb;
        public float thrust = 1f;
    #endregion

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void Update(){
        if(Input.GetKey("w")){
            rb.AddForce(camera.transform.forward * thrust);
        }
        if(rb.velocity.magnitude> 10){
            rb.AddForce(rb.velocity * -thrust);
        }
    }
}
