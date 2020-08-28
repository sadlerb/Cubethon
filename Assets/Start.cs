using UnityEngine.SceneManagement;
using UnityEngine;

public class Start : MonoBehaviour
{

    public void Begin(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
    }
        
    
}
