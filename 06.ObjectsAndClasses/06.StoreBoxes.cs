
List<Box> boxes = new List<Box>();

string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] boxInfo = input.Split();

    string serialNomber = boxInfo[0];
    string itemName = boxInfo[1];
    int itemQuantity = int.Parse(boxInfo[2]);
    decimal price = decimal.Parse(boxInfo[3]);

    Item item = new Item(itemName, price);
    Box box = new Box(serialNomber, item, itemQuantity);
    boxes.Add(box);
}
// Sort all boxes by price  
foreach (var box in boxes.OrderByDescending(x => x.PricePerBox))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
    Console.WriteLine($"-- ${box.PricePerBox:f2}");
}


public class Item
{
    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }

    public decimal Price { get; set; }
}

public class Box
{
    public Box(string serialNumber, Item item, int quantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        Quantity = quantity;
    }

    public string SerialNumber { get; set; }

    public Item Item { get; set; }

    public int Quantity { get; set; }

    public decimal PricePerBox 
    {
        get
        {
            return Quantity * Item.Price;
        }
    }
}