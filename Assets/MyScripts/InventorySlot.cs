using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    ScriptableItem item;
    public Image itemIcon;
    public Button removebutton;
    public int index;

    public void AddItem(ScriptableItem newItem)
    {
        item = newItem;
        itemIcon.sprite = item.itemIcon;
        itemIcon.enabled = true;
        removebutton.interactable = true;
        Debug.Log("ADD ITEM " + item.itemName + " / " + newItem.itemName);

    }

    public void ClearSlot()
    {
        item = null;
        itemIcon.sprite = null;
        itemIcon.enabled = false;
        removebutton.interactable = false;
    }

    public void RemoveItem()
    {
        Inventory.instance.RemoveItem(item);
    }

    public void UseItem()
    {
        if(item != null)
        {            
            //Inventory.instance.DebugItems();
            item.Use();
            Debug.Log(index);
            //Debug.Log(Inventory.instance.itemList[index].itemName);
            //Inventory.instance.itemList[index].Use();
        }
    }

}
