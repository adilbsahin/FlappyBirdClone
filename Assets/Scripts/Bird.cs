using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public bool isDead = false;

    public float velocity = 1f;
    private Rigidbody2D rb2d;

    public GameManager managerGame;

    public GameObject deathScreen;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
    }

    
    void Update()
    {
        //týklamayý kontrol eder
        if(Input.GetMouseButtonDown(0))
        {
            //sýçratma
            rb2d.velocity = Vector2.up * velocity;
        }
    }

    //skor arttýrma kontrolü
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    //oyun bitiþi
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            deathScreen.SetActive(true);
        }
    }
}
