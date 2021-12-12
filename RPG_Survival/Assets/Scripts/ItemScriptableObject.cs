using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    Default,
    Tree,
    Plant,
    Weapon,
    Food,
    Armor
}

public class ItemScriptableObject : ScriptableObject
{
    public string itemName;
    public int maximumAmount;
    public string itemDescription;
    public ItemType itemType;
    public GameObject itemPrefab;
    public Sprite icon;
}
