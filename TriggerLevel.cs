using UnityEngine;

public class TriggerLevel : MonoBehaviour
{   public GameManager gamemanager;
    public void OnTriggerEnter()
    {
        gamemanager.CompleteLevel1();
    }
}
