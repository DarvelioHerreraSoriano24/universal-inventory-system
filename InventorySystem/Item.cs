public class Item { // Must be Capital 'I'
    public string ID;
    public string Name;
    public double Price;
    public int StackLimit;

    // Constructor name MUST match class name exactly
    public Item(string id, string name, double price, int stackLimit) {
        this.ID = id;
        this.Name = name;
        this.Price = price;
        this.StackLimit = stackLimit;
    }
}