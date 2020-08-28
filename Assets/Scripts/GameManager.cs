using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    bool gameOver = false;
    public float  restartDelay = 1f;
    public void EndGame(){
        if(gameOver == false){
            gameOver = true;
            Debug.Log("Game Over");
            Invoke("Restart",restartDelay); 
        }

    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
    }
}
