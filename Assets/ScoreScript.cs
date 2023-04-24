using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    float speed = 10;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI boundaryText;
    private int Scorenum;
    private bool sentinel = false;


    // took inspiration from you :)
    // Start is called before the first frame update
    void Start()
    {
        Scorenum = 0;
        scoreText.text = "Score: " + Scorenum;
        boundaryText.text = "";
    }


    private void OnTriggerEnter2D(Collider2D rectangles)
    {
        if (!sentinel) {
            if (rectangles.tag == "Rectangles") {
                Scorenum++;
                scoreText.text = "Score: " + Scorenum;
            } else if (rectangles.tag == "boundary") {
                scoreText.text = "";
                boundaryText.text = "Game over! Final Score: " + Scorenum;
                sentinel = true;
            }
        }
        GetComponent<Rigidbody2D>().velocity = Random.onUnitSphere* speed;
    }
    
    


}
