using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject {

    public Item currentItem;
    public List<Item> items = new List<Item>();
    public int numberOfKeys;
    public int numberOfCoins;
    public float maxMagic = 10;
    public float currentMagic;

    public void OnEnable()
    {
        currentMagic = maxMagic;
    }

    public bool CheckForItem(Item item)
    {
        if (items.Contains(item))
        {
            return true;
        }
        return false;
    }

    public void ReduceMagic(float magicCost)
    {
        currentMagic -= magicCost;
    }

    public void AddItem(Item itemToAdd)
    {
        // is the item a key?
        if (itemToAdd.isKey)
        {
            numberOfKeys++;
        }
        else
        {
            if (!items.Contains(itemToAdd))
            {
                items.Add(itemToAdd);
            }
        }
    }
	
}
