
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody Rb;
    public float M = 500f;

    public float ForwardForce = 1000f;
    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("d")) {

            Rb.AddForce( M * Time.deltaTime,0,0);
        }
        if (Input.GetKey("a"))
        {

            Rb.AddForce(-M * Time.deltaTime, 0, 0);
        }
        if (Rb.position.y < -1) {

            FindObjectOfType<GameManager>().EndGame();
        
        }
    }
     


        }


    

