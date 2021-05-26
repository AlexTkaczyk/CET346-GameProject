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
    public InteractableObjects leverUp, leverDown,phosphorusLight, spider, randomStuff,
        batteryThing, batteryThingWithBatteries, oilSpill;
    public GameObject fire;
    public Animator platformAnimator, particleAnimator;

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
            item.Use();
            if (item.itemName == "OilCan")
            {
                leverUp.interactable.SetActive(false);
                leverDown.interactable.SetActive(true);
                platformAnimator.Play("Platform_Animation");
            }

            if(item.itemName == "PhosphorLight")
            { 
                phosphorusLight.interactable.SetActive(true);
                StartCoroutine(DestroyCoroutine());
            }

            if (item.itemName == "Knife")
            {
                oilSpill.interactable.SetActive(true);
            }

            if (item.itemName == "Lighter")
            {
                fire.SetActive(true);
                StartCoroutine(FireCoroutine());
            }

            if (item.itemName == "BatteryBlue")
            {

            }

            if (item.itemName == "BatteryYellow")
            {

            }

            if (item.itemName == "BatteryRed")
            {

            }

            if (item.itemName == "BatteryPurple")
            {
                batteryThing.interactable.SetActive(false);
                batteryThingWithBatteries.interactable.SetActive(true);
                particleAnimator.Play("Portal_Animation");
            }

            if (item.itemName == "BatteryGreen")
            {

            }


        }
    }

    IEnumerator DestroyCoroutine()
    {
        yield return new WaitForSeconds(5);
        Destroy(spider.interactable);
        Destroy(phosphorusLight.interactable);
    }

    IEnumerator FireCoroutine()
    {
        yield return new WaitForSeconds(5);
        Destroy(randomStuff.interactable);
        fire.SetActive(false);
    }
}
