using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindManager : MonoBehaviour{   
    void Update() {
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)){
                if(hit.collider.tag == "Rewind")
                    hit.transform.gameObject.GetComponent<RewindObject>().Select();
            }
        }
    }
}
