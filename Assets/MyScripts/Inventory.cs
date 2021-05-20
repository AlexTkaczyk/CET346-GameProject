using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance");
            return;
        }
        instance = this;
    }

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int slots = 5;
    public List<ScriptableItem> itemList = new List<ScriptableItem>();

    public bool AddItem(ScriptableItem item)
    {
        if(itemList.Count >= slots)
        {
            Debug.Log("Not enough room");
            return false;
        }
        
        itemList.Add(item);

        if(onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }

        return true;
    }

    public void RemoveItem(ScriptableItem item)
    {
        itemList.Remove(item);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }

    public void DebugItems()
    {
        for(int i = 0; i < itemList.Count; i++)
        {
            Debug.Log(itemList[i].itemName);
        }
    }
}

