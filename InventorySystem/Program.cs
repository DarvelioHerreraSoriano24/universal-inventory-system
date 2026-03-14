// 1. Initialize the Manager
InventoryManager myInv = new InventoryManager();

// 2. Create some "Mock Data" (Test Items)
Item sword = new Item("S01", "Silver Sword", 150.0, 1);
Item potion = new Item("P01", "Health Potion", 10.0, 10);

// 3. Execute the Logic
Console.WriteLine("--- Starting Inventory Test ---");
myInv.AddItem(sword);
myInv.AddItem(potion);

// 4. Verification
Console.WriteLine($"Items in inventory: {myInv.Items.Count}");
Console.WriteLine("--- Test Complete ---");