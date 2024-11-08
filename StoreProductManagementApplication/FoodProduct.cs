using System;

namespace StoreProductManagementApplication;

public class FoodProduct : Product
{
    public FoodProduct(string name, double price, int stockQuantity, DateTime expirationDate) : base(name, price, stockQuantity)
    {
        ExpirationDate = expirationDate;
    }

    public DateTime ExpirationDate { get; set; }
}
