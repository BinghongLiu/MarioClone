using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public GameObject scoreboard;
    private float points = 0;

    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro point = scoreboard.GetComponent<TextMeshPro>();
        point.text = "Points: " + points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Player") {
            
            Destroy(gameObject);
            points++;
            TextMeshPro point = scoreboard.GetComponent<TextMeshPro>();
            point.text = "Points: " + points.ToString();
        }
    }
}
