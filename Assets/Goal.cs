using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public string goaltext;
    [SerializeField]
    private int goalCount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            goalCount++;
            if (goalCount >= 3)
            {
                Application.Quit();
                UnityEditor.EditorApplication.isPlaying = false;
            }
            collision.gameObject.GetComponent<Ball>().Reset();
            
        }
    }
}
