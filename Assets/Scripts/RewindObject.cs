using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindObject : MonoBehaviour{
    #region 
        public Vector3 originalPosition;
        public Quaternion originalRotation;
        public Vector3 unwindedPosition;
        public Quaternion unwindedRotation;
        private bool selected = false;
    #endregion
    
    void Start(){
        
    }

    void Update(){
        if(Input.GetKey("f")){
            Rewind();
        }
        if(Input.GetKey("u")){
            Unwind();
        }
    }

    public void Select(){
        if(!selected){
            selected = true;
            GetComponent<Floater>().enabled = false;
        }else{    
            selected = false;
            GetComponent<Floater>().enabled = true;
        }
    }


    
    public void Rewind(){
        if(selected){
            transform.position = Vector3.Lerp(transform.position,originalPosition,Time.deltaTime * 1);
            transform.rotation = Quaternion.Lerp(transform.rotation,originalRotation,Time.deltaTime * 1);
        }
    }

    public void Unwind(){
        if(selected){
            transform.position = Vector3.Lerp(transform.position,unwindedPosition,Time.deltaTime * 1);
            transform.rotation = Quaternion.Lerp(transform.rotation,unwindedRotation,Time.deltaTime * 1);
        }
    }
}
