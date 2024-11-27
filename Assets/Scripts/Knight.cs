using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Knight : PlayerStats
{
    public int ClassHealth { get { return Health; } set { Health = value; } }
    public int ClassDefense { get { return Defense; } set { Defense = value; } }
    public int ClassAttack { get { return Attack; } set { Attack = value; } }
}
