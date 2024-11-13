using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem
{
    public int id;
    public int value;
    public new string name;

    public override string ToString()
    {
        return id.ToString() + " ID | " + name + " Name | " + value + " Value.";
    }
}
