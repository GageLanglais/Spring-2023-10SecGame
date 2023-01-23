using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{
    public float movespeed = 5f;

    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public Text lose;
    public AudioSource musicSource;
    public AudioClip background;
    public AudioClip defeat;

    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        lose.text = ("");
        audioSource = GetComponent<AudioSource>();
        musicSource.clip = background;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY);
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * movespeed, moveDirection.y * movespeed);
    }
    private void OnDestroy ()
    {
        musicSource.clip = defeat;
        musicSource.Play();
        lose.text = ("You lost!");
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Flower"))
        {
            Destroy(collision.gameObject);
            movespeed ++;
        }
    }

}