using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MyGUI : MonoBehaviour
{
    public string playerStatText = "Choose a Player...";
    public string playerChosen = "";
    public string clutch;
    [SerializeField] private Player1 p_one;
    [SerializeField] private Player2 p_two;
    [SerializeField] private Player3 p_three;
    [SerializeField] private GameObject fight;

    private void Awake()
    {
        p_one.idk();
    }

    private void Update()
    {
        clutch = p_one.CLUTCH;
    }
    private void OnGUI()
    {
        GUI.Box(new Rect(350, 70, 700, 600), "Player Creation");
        GUI.Label(new Rect(350, 70, 200, 200), clutch);

        if (GUI.Button(new Rect(375, 110, 150, 80), "Player 1 Stats"))
        {
            Debug.Log("kill myself");
            playerStatText = p_one.ClassName + " Stats: \n\rHealth: " + p_one.ClassHealth + "\n\rDefense: " + p_one.ClassDefense + "\n\rAttack: " + p_one.ClassAttack;
            playerChosen = "Player 1 ";
            Debug.Log(p_one.ClassDefense);
        }

        if (GUI.Button(new Rect(375, 250, 150, 80), "Player 2 Stats"))
        {
            Debug.Log("kill myself");
            playerStatText = p_two.ClassName + " Stats: \n\rHealth: " + p_two.ClassHealth + "\n\rDefense: " + p_two.ClassDefense + "\n\rAttack: " + p_two.ClassAttack;
            playerChosen = "Player 2 ";
        }

        if (GUI.Button(new Rect(375, 390, 150, 80), "Player 3 Stats"))
        {
            Debug.Log("kill myself");
            playerStatText = p_three.ClassName + " Stats: \n\rHealth: " + p_three.ClassHealth + "\n\rDefense: " + p_three.ClassDefense + "\n\rAttack: " + p_three.ClassAttack;
            playerChosen = "Player 3 ";
        }

        if (GUI.Button(new Rect(375, 530, 200, 80), "Lock in Character"))
        {
            Debug.Log(playerChosen + "was chosen.");
            if (playerChosen == "")
            {
                Debug.Log("bro does htis work???");
                playerStatText = "Choose a player first!";
            }
            else
            {
                fight.SetActive(true);
            }
        }

        GUI.Label(new Rect(700,250,200,200), playerStatText);
    }
}
