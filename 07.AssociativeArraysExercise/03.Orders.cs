
Dictionary<string, List<double>> productList = new Dictionary<string, List<double>>();

string input;

while ((input = Console.ReadLine()) != "buy")
{
    string[] productInfo = input
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string product = productInfo[0];
    double price = double.Parse(productInfo[1]);
    double quantity = double.Parse(productInfo[2]);

    var productValue = new List<double> { price, quantity };

    if (!productList.ContainsKey(product))
    {
        productList.Add(product, productValue);
    }
    else
    {
        productList[product].Add(quantity);

        productList[product].RemoveAt(0);
        productList[product].Insert(0, price);
    }
    
}


foreach (var item in productList)
{
    double sum = (item.Value.Sum() - item.Value.First()) * item.Value.First();
    Console.WriteLine($"{item.Key} -> {sum:f2}");
}

