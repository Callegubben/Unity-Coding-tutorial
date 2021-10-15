using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{
    public bool countdown;

    [SerializeField]
    private Text _goaltext;

    [SerializeField]
    private Text _nameInput;

    public bool playerReady = false;
    private string playerName;
    private int goalcounter;
    [SerializeField]
    private GameManager _gameManager;

    public void Goal()
    {
        goalcounter++;
        _goaltext.text = $"{playerName}: " + goalcounter;

        if (goalcounter >= 3)
        {
            _gameManager.Win(playerName);
        }

    }
    public void LoseLife()
    {
        goalcounter++;
        _goaltext.text = $"Lives: " + (3-goalcounter);

        if (goalcounter >= 3)
        {
            _gameManager.Lose();
        }

    }
    public void SetReady()
    {
        playerName = _nameInput.text;
        _goaltext.text = playerName;
        playerReady = !playerReady;
        _gameManager.StartPlay();
        //I see you <3
    }
}
