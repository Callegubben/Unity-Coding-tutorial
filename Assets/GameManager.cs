using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text p1Text;
    public Text p2Text;
    public GameObject ball;

    public void StartPlay()
    {
        if (p1Text.GetComponent<TextHandler>().playerReady== true && p2Text.GetComponent<TextHandler>().playerReady == true)
        {
            p1Text.GetComponent<TextHandler>().playerReady = false;
            p2Text.GetComponent<TextHandler>().playerReady = false;
            ball.SetActive(true);
        }
        else
        {
            return;
        }
    }
    public void Win(string name)
    {
        print($"{name} is the winner!");
        SceneManager.LoadScene("MainMenu");
    }

}
