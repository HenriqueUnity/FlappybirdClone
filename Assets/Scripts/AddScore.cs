using UnityEngine;

public class AddScore : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
     gameManager = FindObjectOfType<GameManager>();    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.AddPoints();
    }

}
