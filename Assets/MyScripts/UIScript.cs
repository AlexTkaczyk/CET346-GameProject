using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    //public GameObject inventoryUI;
    /*public Inventory inventory;

    private void Start()
    {
        inventory.itemPickedUp += InventoryItemPickedUp;
    }

    public void InventoryItemPickedUp(object sender, InventoryEventArgs e)
    {
        Transform inventoryUI = transform.Find("Inventory");

        foreach(Transform slot in inventoryUI)
        {
            Image image = slot.GetChild(0).GetChild(0).GetComponent<Image>();

            if(!image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.itemImage;
                break;
            }
        }
    }

    /*public void ShowHideInventory()
    {
        if (inventoryUI.activeSelf == false)
        {
            inventoryUI.SetActive(true);
        }
        else
        {
            inventoryUI.SetActive(false);
        }
    }*/


}
