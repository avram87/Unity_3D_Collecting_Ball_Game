using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    bool isGameOver = false;

    public float restartDelay = 1f;
     
    public void EndGame()
    {
        if(isGameOver == false)
        {
            isGameOver = true;
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
