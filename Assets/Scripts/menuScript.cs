using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour{
    public void play(){
        SceneManager.LoadScene(1,LoadSceneMode.Single);
    }

    public void Exit(){
        Application.Quit();
    }
}
