using GrandCircusC_Unit4;
using System.Runtime.InteropServices;

/* 2/14/24 Class work */

// List<Product> products = new List<Product>();
Inventory inventory = new Inventory();

Console.WriteLine("Let's populate our inventory");

while (true)
{
    Console.Write("What is the name of the product");
    string productName = Console.ReadLine();
    double productPrice = double.Parse(Console.ReadLine());
    Console.WriteLine("How many do you have?");
    int count = int.Parse(Console.ReadLine());

    Product newProduct = new Product(productName, productPrice, count);
    inventory.InventoryList.Add(newProduct);
    // products.Add(newProduct);

    Console.WriteLine("Add another product (y/n)?");
    string input = Console.ReadLine();

    if (input.ToLower() != "y")
    {
        break;
    }
}

Console.WriteLine("Here is your inventory");

foreach(Product product in inventory.InventoryList)
{
    Console.WriteLine(product.DisplayProductDetails);
}

Console.WriteLine("What would you like to buy? (case sensitive) ");
string item = Console.ReadLine();

bool doesItemExist = inventory.InventoryList.Any(x => x.Name.ToLower() == item);
if (doesItemExist == false)
{
    Console.WriteLine($"{item} does not exist");
    ExitApplication();
}

Product chosenItem = inventory.InventoryList.Where(x => x.Name.ToLower() == item).First();

Console.WriteLine("How many do you want?");
int amount = int.Parse(Console.ReadLine());
double cost = chosenItem.PurchaseItem(amount);

DiscountManager discount = new DiscountManager();
cost = discount.ApplyMonthlyDiscount(cost, DateTime.Now.Month);
Console.WriteLine($"You owe {cost:C}");


Order order = new Order();
order.Cart.Add(chosenItem);
order.OrderDate = DateTime.Now.Date;
order.TotalAmount = cost;
void ExitApplication()
{
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
    Environment.Exit(0);
}

Console.ReadKey();