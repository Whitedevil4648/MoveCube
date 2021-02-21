using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform players;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = players.position.z.ToString("0");
    }
}
