using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] private float speed;
    private GameManager gameManager;


    private void Start()
    {

        gameManager = FindObjectOfType<GameManager>();
        if (gameManager.score > 4)
        {
            if (gameManager.score > 9)
            {
                if (gameManager.score > 19)
                {
                    speed += 6;
                }
                speed += 4;
            }
            speed += 2;

        }

    }
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }


}
