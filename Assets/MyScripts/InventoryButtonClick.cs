using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButtonClick : MonoBehaviour
{
    InventorySlot inventorySlot;

    private void Start()
    {
        inventorySlot = gameObject.GetComponentInParent<InventorySlot>();
    }
    public void Click()
    {
        if (inventorySlot != null)
        {
            inventorySlot.UseItem();
        }
    }
}
