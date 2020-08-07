using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class pauseMenuScript : MonoBehaviour{
    
    public void reset(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(1,LoadSceneMode.Single);
    }

    public void Exit(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0,LoadSceneMode.Single);
    }
}
