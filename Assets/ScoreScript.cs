using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    private int Scorenum;


    // took inspiration from you :)
    // Start is called before the first frame update
    void Start()
    {
        Scorenum = 0;
        scoreText.text = "Score: " + Scorenum;
    }







}
