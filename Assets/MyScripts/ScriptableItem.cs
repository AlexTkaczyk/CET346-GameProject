﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class ScriptableItem : ScriptableObject
{
    public string itemName = "New Item";
    public Sprite itemIcon = null;

    public virtual void Use()
    {

    }

}
