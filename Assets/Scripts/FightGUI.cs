using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightGUI : MonoBehaviour, DamageSystem
{
    [SerializeField] GameObject Menu;
    [SerializeField] GameObject gameover;
    [SerializeField] MyGUI menuGUI;
    [SerializeField] DemonKing demonKingStat;
    [SerializeField] Knight knightstat;
    [SerializeField] Player1 swordsman;
    [SerializeField] Player2 archer;
    [SerializeField] Player3 mage;
    string PlayerUsed;
    public bool Win;

    // Player Stats
    string p_name;
    int p_health;
    int p_defense;
    int p_attack;
    private void Awake()
    {
        Menu.SetActive(false);
        PlayerUsed = menuGUI.playerChosen;
        Debug.Log(PlayerUsed);
        switch (PlayerUsed)
        {
            case "Player 1 ":
                p_name = swordsman.ClassName;
                p_health = swordsman.ClassHealth;
                p_defense = swordsman.ClassDefense;
                p_attack = swordsman.ClassAttack;
                break;
            case "Player 2 ":
                p_name = archer.ClassName;
                p_health = archer.ClassHealth;
                p_defense = archer.ClassDefense;
                p_attack = archer.ClassAttack;
                break;
            case "Player 3 ":
                p_name = mage.ClassName;
                p_health = mage.ClassHealth;
                p_defense = mage.ClassDefense;
                p_attack = mage.ClassAttack;
                break;
        }
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(350, 70, 700, 600), "Fight!");
        GUI.Label(new Rect(600, 110, 300, 300), PlayerUsed + "will fight the Demon King!");

        if (GUI.Button(new Rect(400, 400, 100, 100), "Attack"))
        {
            Debug.Log("you've attacked");
            playerdmgSystem(p_attack);
        }

        if (GUI.Button(new Rect(400, 550, 100, 100), "Boss Attacks"))
        {
            Debug.Log("you've been shit on, go kill yourself");
            bossdmgSystem(demonKingStat.ClassAttack);
        }

        GUI.Label(new Rect(800, 250, 300, 300), "Boss Health: " + demonKingStat.ClassHealth + "\n\r\n\rPlayer Health: " + p_health + "\n\r\n\rCompanion Health: " + knightstat.ClassHealth);
    }

    public void bossdmgSystem(int dmg)
    {
        if (p_defense > 0)
        {
            dmg -= p_defense;
            dmg *= -1;
            Debug.Log(dmg);
            p_health -= dmg;
        }
        else
        {
            p_health -= dmg;
        }
    }

    public void playerdmgSystem(int dmg)
    {
        demonKingStat.ClassHealth -= dmg;
        knightstat.ClassHealth -= dmg;
    }

    private void Update()
    {
        if (demonKingStat.ClassHealth <= 0)
        {
            Win = true;
            gameover.SetActive(true);
        }

        if (p_health <= 0)
        {
            Win = false;
            gameover.SetActive(true);
        }
    }
}
