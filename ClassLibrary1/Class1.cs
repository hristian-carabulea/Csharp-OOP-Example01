/// <summary>
/// Object Oriented Programming: Encapsulation, Abstraction, Set, Get, this, instance & static methods, reference variables as arguments.
/// </summary>
public class Product
{
    //public int productID;
    //public string productName;
    //public double productCost;
    //public double productTax;
    //public int quantityInStock;
    //public readonly string dateOfPurchase;

    // applying abstraction: make fields private and access them only through setters and getters
    private int productID;
    private string productName;
    private double productCost;
    private double productTax;
    private int quantityInStock;
    private readonly string dateOfPurchase;

    public static int TotalNumberOfProducts;
    public const string CategoryName = "Electronics";

    //Constructor gets executed each time the class gets instantiated, e.g. a new Product Object is being created.
    /// <summary>
    /// Return today's date in a string format
    /// </summary>
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    /// <summary>
    /// Set the productID
    /// </summary>
    /// <param name="productID"></param>
    public void SetProductID(int productID) //using this
    {
        this.productID = productID;
    }

    /// <summary>
    /// Get the productID
    /// </summary>
    /// <returns></returns>
    public int GetProductID()
    {
        return productID;
    }

    /// <summary>
    /// Set the productName
    /// </summary>
    /// <param name="value"></param>
    public void SetProductName(string value)
    {
        productName = value;
    }

    /// <summary>
    /// Get the productName
    /// </summary>
    /// <returns></returns>
    public string GetProductName()
    {
        return productName;
    }

    /// <summary>
    /// Set the productCost
    /// </summary>
    /// <param name="value"></param>

    public void SetProductCost(double value)
    {
        productCost = value;
    }

    /// <summary>
    /// Get the productCost
    /// </summary>
    /// <returns></returns>
    public double GetProductCost()
    {
        return productCost;
    }

    /// <summary>
    /// Set the productTax
    /// </summary>
    /// <param name="value"></param>
    public void SetProductTax(double value)
    {
        productTax = value;
    }

    /// <summary>
    /// Get the productTax
    /// </summary>
    /// <returns></returns>
    public double GetProductTax()
    {
        return productTax;
    }

    /// <summary>
    /// Takes an argument or none. Default double value is 4.5
    /// </summary>
    /// <param name="percentage"></param>
    public void CalculateTax(double percentage=4.5)
    {
        double tax; // local variable
        System.Console.WriteLine("\nTax percentage: " + percentage);
        if (productCost <= 2000)
        {
            tax = productCost * 10 / 100;
        }
        else
        {
            tax = productCost * percentage / 100;
        }
        productTax = tax;
    }

    /// <summary>
    /// Method overloading. This method version takes two arguments.
    /// </summary>
    /// <param name="cost"></param>
    /// <param name="percentage"></param>
    public void CalculateTax(double productCost, double percentage)
    {
        double tax; // local variable

        if (productCost <= 2000)
        {
            tax = productCost * 10 / 100;
        }
        else
        {
            tax = productCost * percentage / 100;
        }
        productTax = tax;
    }
    /// <summary>
    /// Set the stock quantity. Takes int parameter.
    /// </summary>
    /// <param name="value"></param>
    public void SetQuantityInStock(int value)
    {
        quantityInStock = value;
    }
    public int GetQuantityInStock()
    {
        return quantityInStock;
    }

    /// <summary>
    /// Get the purchase date. Returns string.
    /// </summary>
    /// <returns>dateOfPurchase</returns>
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }

    /// <summary>
    /// Set the total number of products. Takes int value.
    /// </summary>
    /// <param name="value"></param>
    public static void SetTotalNumberOfProducts(int value)
    {
        TotalNumberOfProducts = value;
    }

    /// <summary>
    /// Get the total number of products.
    /// </summary>
    /// <returns>TotalNumberOfProducts</returns>
    public static int GetTotalNumberOfProducts()
    {
        return TotalNumberOfProducts;
    }

    /// <summary>
    /// Calculates and returns the total inventory number.
    /// </summary>
    /// <param name="product1"></param>
    /// <param name="product2"></param>
    /// <param name="product3"></param>
    /// <returns>total</returns>
    public static int GetTotalProductQuantity(Product product1, Product product2, Product product3)
    {
        int total = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();  
        return total;
    }

}