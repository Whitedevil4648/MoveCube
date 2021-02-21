using UnityEngine.SceneManagement;

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float DelayNo = 2f;
    public GameObject LevelCOMUI;
    public void CompleteLevel1() {

        LevelCOMUI.SetActive(true);

    
    }
    bool GameHasEnded = false;
    public void EndGame()
    { if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", DelayNo);
        }


    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);



    }
}
