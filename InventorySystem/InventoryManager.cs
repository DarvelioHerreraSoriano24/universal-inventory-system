using System;
using System.Collections.Generic;

public class InventoryManager
{
    public List<Item> Items = new List<Item>();

    public void AddItem(Item newItem)
    {
        Items.Add(newItem);
        Console.WriteLine($"Added: {newItem.Name}");
    }

    public void RemoveItem(string id) {
        Items.RemoveAll(i => i.ID == id);
    }
}