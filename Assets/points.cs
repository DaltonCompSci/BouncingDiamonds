using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class points : MonoBehaviour
{


    // took inspiration from you :)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        print("Entering Collision with rect");
        if (col.gameObject.tag == "rectangles")
        {
            print("Entering Collision with rec");

            GameManager.Instance.IncScore(1);

        }
    }


}
