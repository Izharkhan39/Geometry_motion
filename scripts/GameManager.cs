
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
    


{
    public GameObject completelevelUI;

    public void Completelevel()     
    {
        completelevelUI.SetActive(true);
    }

    public float restartdelay = 1f;


    bool gameHasEnded = false;



    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            Invoke("Restart", restartdelay);
        }

       
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
    