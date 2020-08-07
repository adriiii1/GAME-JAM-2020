using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour{

    #region variables
    public Ball ball;
    public int lastPlayerToHit;
    public int p1points = 0;
    public int p2points = 0;
    public int p1games = 0;
    public int p2games = 0;
    public TextMeshProUGUI txtP1;
    public TextMeshProUGUI txtP2;
    public TextMeshProUGUI txtP1g;
    public TextMeshProUGUI txtP2g;
    public GameObject winMenu;
    public TextMeshProUGUI txtWin;
    private Vector3 pos1 = new Vector3(0f,1.5f,-12f);
    private Vector3 pos2 = new Vector3(0f,1.5f,12f);

    private int[] array = new int[]{0, 15, 30 , 40};
    #endregion

    IEnumerator exitTimer(){
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0,LoadSceneMode.Single);
    }
    public void lastPlayerHit(int player){
        lastPlayerToHit = player;
    }

    public void addPointsP(int player){
        if(player == 1){
            if(p1points < 3){
                p1points++;
            }else{
                p1games++;
                p1points = 0;
                p2points = 0;
            }
            ball.resetBall(1);
        }else{
            if(p2points < 3){
                p2points++;
            }else{
                p2games++;
                p1points = 0;
                p2points = 0;
            }
            ball.resetBall(2);
        }
        txtP1.text = array[p1points].ToString();
        txtP2.text = array[p2points].ToString();
        txtP1g.text = p1games.ToString();
        txtP2g.text = p2games.ToString();
        if((p1games >= 3)||(p2games >= 3)){
            ball.transform.position = new Vector3(0f,-14f,0f);
            winMenu.SetActive(true);
            if(p1games > p2games){
                txtWin.text = "PLAYER 1 WINS";
            }else{
                txtWin.text = "PLAYER 2 WINS";
            }
            StartCoroutine(exitTimer());
        }
    }
}
