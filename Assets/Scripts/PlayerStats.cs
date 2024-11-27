using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStats : MonoBehaviour
{
    [SerializeField] protected string Name;
    [SerializeField] protected int Health;
    [SerializeField] protected int Defense;
    [SerializeField] protected int Attack;

    public virtual void idk()
    {

    }
}
