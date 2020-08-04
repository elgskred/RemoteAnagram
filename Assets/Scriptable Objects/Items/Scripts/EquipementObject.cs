
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equpment Object", menuName = "Inventory System/Items/Equipment")]
public class EquipementObject : ItemObject
{
    public float atkBonus;
    public float defenceBonus;

    public void Awake()
    {
        //type = ItemType.BodyArmor;
    }
}
