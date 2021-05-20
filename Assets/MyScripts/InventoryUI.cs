using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    InventorySlot[] itemSlots;

    // Start is called before the first frame update
    void Start()
    {
        Inventory.instance.onItemChangedCallback += UpdateUI;
        itemSlots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    void UpdateUI()
    {
        for(int i = 0; i < itemSlots.Length; i++)
        {
            if(i < Inventory.instance.itemList.Count)
            {
                itemSlots[i].AddItem(Inventory.instance.itemList[i]);
            }
            else
            {
                itemSlots[i].ClearSlot();
            }
        }
    }
}
