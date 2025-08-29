namespace Backend_intro;

public class ProductInventory
{
    public static bool CheckStock(string[] cart)
    {
        //Inventory
        string[] products = new string[] { "67, Apple", "9, Banana", "89, Orange" };
        
        // Shopping cart
        // Parse products inventory
        // Check cart versus inventory
        bool isProductInStock = true;

        if (!isProductInStock) return false;
        return true;
    }
}