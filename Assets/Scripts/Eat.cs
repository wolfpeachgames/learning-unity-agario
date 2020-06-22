using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eat : MonoBehaviour
{
    public string Tag;
    public float increase;

    [Header("Scoring")]
    public Text scoreText;
    private int score = 0;


    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("got here");
        if (other.CompareTag(Tag))
        {
            transform.localScale += new Vector3(increase, increase, increase);
            Destroy(other.gameObject);

            score += 1;
            scoreText.text = "SCORE: " + score;
        }
    }
}
