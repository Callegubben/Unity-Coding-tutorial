using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{
    [SerializeField]
    private Text _goaltext;
    public bool playerReady = false;
    private string playerName;
    private int goalcounter;
    [SerializeField]
    private GameManager _gameManager;
    private void Start()
    {
        if (_goaltext == false)
        {
            _goaltext = GetComponent<Text>();
        }
    }
    public void Goal()
    {
        goalcounter++;
        _goaltext.text = $"{playerName}: " + goalcounter;

        if (goalcounter >= 3)
        {
            _gameManager.Win(playerName);
        }

    }
    public void SetReady()
    {
        playerName = _goaltext.text;
        playerReady = !playerReady;
        _gameManager.StartPlay();
    }
}
