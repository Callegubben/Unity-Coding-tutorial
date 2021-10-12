using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public TextHandler goal;

    public int goalCount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            goal.Goal();
            collision.gameObject.GetComponent<Ball>().Reset();
            
        }
    }
}
