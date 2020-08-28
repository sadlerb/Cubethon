
using UnityEngine;

public class Collison : MonoBehaviour

{
    public Movement movement;
    void OnCollisionEnter (Collision collisioninfo){
        if (collisioninfo.collider.tag == ("Obstacle")){
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
