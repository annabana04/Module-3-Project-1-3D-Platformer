using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TMP_Text scoreText;
    int score = 0;

    private void Awake()
    {
        scoreText.text = "Score: " + score.ToString();
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
        scoreText.text = "Score: " + score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
        Debug.Log("Score: " + score);
        scoreText.text = "Score: " + score.ToString();
    }
}
