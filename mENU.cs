using UnityEngine.SceneManagement;
using UnityEngine;

public class mENU : MonoBehaviour
{
    public void GameStart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void LevelUI()
    {
        SceneManager.LoadScene("LevelUI");



    }
    public void QuitIng()
    {
        Application.Quit();



    }

}
