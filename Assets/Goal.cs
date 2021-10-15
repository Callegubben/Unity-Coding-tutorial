using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public TextHandler target;
    public bool lives;

    public int goalCount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!lives)
            {
                target.Goal();
            }
            else
            {
                target.LoseLife();
            }
            collision.gameObject.GetComponent<Ball>().Reset();
        }
    }
}
