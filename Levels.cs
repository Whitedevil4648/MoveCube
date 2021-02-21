using UnityEngine.SceneManagement;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Level01");



    }
    public void Level2()
    {
        SceneManager.LoadScene("Level02");



    }
    public void Level3()
    {
        SceneManager.LoadScene("Level03");



    }
    public void Back()
    {
        SceneManager.LoadScene("mENU");



    }
}
