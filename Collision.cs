
using UnityEngine;

public class Collision : MonoBehaviour

{
    public PlayerMovement movement;
    public AudioClip aUDIO;
    public AudioSource aa;
    void OnCollisionEnter(UnityEngine.Collision collision1)
    {
        if (collision1.collider.tag == "Obstacle") {
            aa.PlayOneShot(aUDIO,10);
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
           
        }
     
    }
}
