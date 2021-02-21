using UnityEngine.SceneManagement;
using UnityEngine;

public class MMMM : MonoBehaviour
{
    public GameObject LevelCOMUI;
    public void mmm()
    {

        SceneManager.LoadScene("mENU");



    }
    public void PauseGame()
    {

        Time.timeScale = 0;
        LevelCOMUI.SetActive(true);
    }

    public void ResumeGame()
    {
        LevelCOMUI.SetActive(false);
        Time.timeScale = 1;
    }
}
