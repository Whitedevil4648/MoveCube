using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelComplete1 : MonoBehaviour
{
    public void Nextlevel1()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
