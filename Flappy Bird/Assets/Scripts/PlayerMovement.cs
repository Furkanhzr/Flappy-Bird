using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField] private float jumpSpeed = 3f;
    [SerializeField] private GameObject deadScreen;
    [SerializeField] private AudioSource dieSFX;
    [SerializeField] private AudioSource pointSFX;
    [SerializeField] private AudioSource flySFX;

    //private GameManager gameManager;
    void Start()
    {
        Time.timeScale = 1f;
        deadScreen.SetActive(false);
        rb2d = GetComponent<Rigidbody2D>(); //verilen component'i alır.
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //getKey tuşa basılı tuttuğunda, getKeyDown ise bastığında
        {
            rb2d.velocity = Vector2.up * jumpSpeed; //velocity "hız" demektir.
            //zıplama sesi
            flySFX.Play();

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Scoring")
        {
            //gameManager'a erişmek için...
            FindObjectOfType<GameManager>().IncreaseScore(); //FindObjectOfType içine verdiğim isimdeki bir objeyi ara ve içindeki scripte git.
            //gameManager.IncreaseScore();

            //scoring sesi
            pointSFX.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0f;
            deadScreen.SetActive(true);
            //ölme sesi
            dieSFX.Play();
        }
    }
}
