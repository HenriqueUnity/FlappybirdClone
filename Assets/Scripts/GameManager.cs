using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int score;

    [SerializeField]private TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text = $"{score}";
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void Quitgame()
    {
        Application.Quit(); 
    }

    public  void AddPoints()
    {
        score++;
        scoreText.text = $"{score}";
    }
}


