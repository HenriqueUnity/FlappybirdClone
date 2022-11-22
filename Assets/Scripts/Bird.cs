using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody2D myRigidbody;
    [SerializeField] private GameObject gameOver;
    private AudioSource audioSource;
    [SerializeField] AudioSource gameOverAudio;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        myRigidbody.velocity = Vector2.up * speed;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myRigidbody.velocity = Vector2.up * speed;
            audioSource.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver.SetActive(true);
        gameOverAudio.Play();
        Time.timeScale = 0;


    }
}
