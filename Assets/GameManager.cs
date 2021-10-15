using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text p1Text;
    public Text p2Text;
    public float blocksLeft = 1;
    public GameObject ball;

    [SerializeField]
    private bool pvp;
    [SerializeField]
    private Text _endOfGameText;

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
        ball.gameObject.GetComponent<Ball>().reset = false;
        _endOfGameText.gameObject.SetActive(true);
        if (pvp)
        {
            _endOfGameText.text = $"{name} is the winner!";
        }
        else
        {
            _endOfGameText.text = $"You win!";
        }
        StartCoroutine(GameOver());
    }
    public void Lose()
    {
        ball.gameObject.GetComponent<Ball>().reset = false;
        _endOfGameText.gameObject.SetActive(true);
        _endOfGameText.text = "Game Over";
        StartCoroutine(GameOver());
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSecondsRealtime(3);
        _endOfGameText.text = "3";
        _endOfGameText.gameObject.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }

}
