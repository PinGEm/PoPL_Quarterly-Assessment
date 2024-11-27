using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] FightGUI fightgui;
    [SerializeField] GameObject fight;
    bool WhoWon;
    string LabelText;
    private void Awake()
    {
        fight.SetActive(false);
        WhoWon = fightgui.Win;

        if (WhoWon == true)
        {
            LabelText = "Player has won";
        }
        else
        {
            LabelText = "Player has lost";
        }
    }
    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 1920, 1080), "");
        GUI.Label(new Rect(650, 100, 200, 300), "Game Over!\n\r" + LabelText);
    }
}
