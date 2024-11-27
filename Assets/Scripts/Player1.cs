using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Player1 : PlayerStats
{
    public string ClassName { get { return Name; } set { Name = value; } }
    public int ClassHealth { get { return Health; } set { Health = value; } }
    public int ClassDefense { get { return Defense; } set { Defense = value; } }
    public int ClassAttack { get { return Attack; } set { Attack = value; } }

    public string CLUTCH;
    public override void idk()
    {
        CLUTCH = "CLUTCHCOMEBACK!!";
        print("i implemented polymorphism NOT FAKE !!!!!!");
    }
}
