using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Card", menuName = "Card")]
public class ObjectCard : ScriptableObject
{
    public new string name;
    public string description;

    public int power;
    public int health;
    public int attack;
}
