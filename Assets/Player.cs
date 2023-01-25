using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    public float force;
    private float health = 3;
    private float score = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText2;

    public TextMeshProUGUI healthText;

    public GameObject[] bloods;
    public GameObject deathScreen;

    private void Start()
    {
        Time.timeScale = 0f;
        scoreText.text = score.ToString();
        healthText.text = health.ToString();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        rb.velocity = Vector2.up * force;
    }

    private void Update()
    {
        if (health <= 0)
        {
            deathScreen.SetActive(true);
            Time.timeScale = 0f;
        }

        scoreText2.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("1.5"))
        {
            score += 1.5f;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("3.75"))
        {
            score+= 3.75f;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("4"))
        {
            score += 4;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("5.25"))
        {
            score += 5.25f;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("death"))
        {
            health--;
            healthText.text = health.ToString();
            Instantiate(bloods[Random.Range(0, bloods.Length)], transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }

        if (other.CompareTag("health"))
        {
            if(health < 3)
            {
                health++;
                healthText.text = health.ToString();
                Destroy(other.gameObject);
            }
        }

        if (other.CompareTag("stop"))
        {
            deathScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Pouse()
    {
        Time.timeScale = 0f;
    }

    public void StartG()
    {
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
