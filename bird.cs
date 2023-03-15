using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bird : MonoBehaviour
{
    private Rigidbody2D rb;
    public Text scoreText;
    public int score;
    public float jumbforce;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            rb.velocity = new Vector2(rb.velocity.x,jumbforce);
        }
    }
    void OnCollisionEnter2D (Collision2D other)
    {
     if(other.gameObject.tag=="pillar")
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
    }
    public void updatescore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
