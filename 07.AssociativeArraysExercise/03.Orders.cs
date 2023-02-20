string input;

Dictionary<string, double> products = new Dictionary<string, double>();
Dictionary<string, int> productQuantity = new Dictionary<string, int>();

while ((input = Console.ReadLine()) != "buy")
{
    string[] productIngo = input.Split(" ");
    string prodKey = productIngo[0];
    double price = double.Parse(productIngo[1]);
    int quantity = int.Parse(productIngo[2]);

    if (!products.ContainsKey(prodKey))
    {
        products.Add(prodKey, price);
        productQuantity.Add(prodKey, quantity);
    }
    else
    {
        products[prodKey] = price;
        productQuantity[prodKey] += quantity;
    }
}
foreach (var product in products)
{
    foreach (var item in productQuantity)
    {
        if (product.Key == item.Key)
        {
            Console.WriteLine($"{product.Key} -> {product.Value * item.Value:f2}");
        }

    }
}