/// <summary>
/// Object Oriented Programming: Encapsulation, Abstraction, Set, Get, this, instance & static methods, reference variables as arguments.
/// </summary>
class Program
{
    static void Main()
    {
        //local constant
        const string developerName = "Hristian";

        //create reference variables. Reference variables are stored in the Stack.
        Product product1, product2, product3;

        //create objects. Objects are stored in Heap.
        product1 = new Product();
        //Product.TotalNumberOfProducts++;
        Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts() + 1);

        product2 = new Product();
        //Product.TotalNumberOfProducts++;
        Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts() + 1);

        product3 = new Product();
        //Product.TotalNumberOfProducts++;
        Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts() + 1);

        // initialize fields
        //product1.productID = 1001;
        product1.SetProductID(1001);

        //product1.productName = "Mobile";
        product1.SetProductName("Mobile");

        //product1.productCost = 200;
        product1.SetProductCost(200);

        // product1.quantityInStock = 1200;
        product1.SetQuantityInStock(1200);

        //product2.productID = 1002;
        //product2.productName = "Laptop";
        //product2.productCost = 20001;
        //product2.quantityInStock = 1300;

        product2.SetProductID(1002);
        product2.SetProductName("Laptop");
        product2.SetProductCost(20001);
        product2.SetQuantityInStock(1300);

        //product3.productID = 1003;
        //product3.productName = "Speakers";
        //product3.productCost = 100;
        //product3.quantityInStock = 2600;

        product3.SetProductID(1003);
        product3.SetProductName("Speakers");
        product3.SetProductCost(100);
        product3.SetQuantityInStock(2600);


        product1.CalculateTax(9.2);
        product2.CalculateTax();
        product3.CalculateTax(15.2);

        //print values
        //System.Console.WriteLine("Product ID: " + product1.productID);
        //System.Console.WriteLine("Product Name: " + product1.productName);
        //System.Console.WriteLine("Product Cost: " + product1.productCost);
        //System.Console.WriteLine("Product Quantity in Stock: " + product1.quantityInStock);
        //System.Console.WriteLine("Date of Purchase: " + product1.dateOfPurchase);
        //System.Console.WriteLine("Product tax: " + product1.productTax);

        //System.Console.WriteLine("\nProduct ID: " + product2.productID);
        //System.Console.WriteLine("Product Name: " + product2.productName);
        //System.Console.WriteLine("Product Cost: " + product2.productCost);
        //System.Console.WriteLine("Product Quantity in Stock: " + product2.quantityInStock);
        //System.Console.WriteLine("Date of Purchase: " + product2.dateOfPurchase);
        //System.Console.WriteLine("Product tax: " + product2.productTax);

        //System.Console.WriteLine("\nProduct ID: " + product3.productID);
        //System.Console.WriteLine("Product Name: " + product3.productName);
        //System.Console.WriteLine("Product Cost: " + product3.productCost);
        //System.Console.WriteLine("Product Quantity in Stock: " + product3.quantityInStock);
        //System.Console.WriteLine("Date of Purchase: " + product3.dateOfPurchase);
        //System.Console.WriteLine("Product tax: " + product3.productTax);

        // using gets instead of accessing the fields themselves.
        System.Console.WriteLine("Product ID: " + product1.GetProductID());
        System.Console.WriteLine("Product Name: " + product1.GetProductName());
        System.Console.WriteLine("Product Cost: " + product1.GetProductCost());
        System.Console.WriteLine("Product Quantity in Stock: " + product1.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + product1.GetDateOfPurchase());
        System.Console.WriteLine("Product tax: " + product1.GetProductTax());

        System.Console.WriteLine("\nProduct ID: " + product2.GetProductID());
        System.Console.WriteLine("Product Name: " + product2.GetProductName());
        System.Console.WriteLine("Product Cost: " + product2.GetProductCost());
        System.Console.WriteLine("Product Quantity in Stock: " + product2.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());
        System.Console.WriteLine("Product tax: " + product2.GetProductTax());

        System.Console.WriteLine("\nProduct ID: " + product3.GetProductID());
        System.Console.WriteLine("Product Name: " + product3.GetProductName());
        System.Console.WriteLine("Product Cost: " + product3.GetProductCost());
        System.Console.WriteLine("Product Quantity in Stock: " + product3.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());
        System.Console.WriteLine("Product tax: " + product3.GetProductTax());


        //Product.Method1();
        //int totalProductsQuantity = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
        System.Console.WriteLine("\nThe quantity of all products is: " + Product.GetTotalProductQuantity(product1, product2, product3));

        //System.Console.WriteLine("\nThe number of products in inventory: " + Product.TotalNumberOfProducts);
        System.Console.WriteLine("\nThe number of products in inventory: " + Product.GetTotalNumberOfProducts());

        System.Console.WriteLine("\nProduct Category: " + Product.CategoryName);

        System.Console.WriteLine("\nDeveloper Name: " + developerName);

        System.Console.ReadKey();
    }
}
