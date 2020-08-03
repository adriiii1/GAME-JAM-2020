using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour{

    #region variables
    public Ball ball;
    public int lastPlayerToHit;
    public int p1points = 0;
    public int p2points = 0;
    public TextMeshProUGUI txtP1;
    public TextMeshProUGUI txtP2;

    private int[] array = new int[]{0, 15, 30 , 40};
    #endregion
    void Start(){
        
    }

    void Update(){
        
    }

    public void lastPlayerHit(int player){
        lastPlayerToHit = player;
    }

    public void addPointsP(int player){
        if(player == 1){
            p1points++;
            txtP1.text = array[p1points].ToString();
        }else{
            p2points++;
            txtP2.text = array[p2points].ToString();
        }
    }
}
