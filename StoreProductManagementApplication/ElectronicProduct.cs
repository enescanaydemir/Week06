using System;

namespace StoreProductManagementApplication;

public class ElectronicProduct : Product
{
    public ElectronicProduct(string name, double price, int stockQuantity, string brand, bool ısRechargeable) : base(name, price, stockQuantity)
    {
        Brand = brand;
        IsRechargeable = ısRechargeable;
    }

    public string Brand { get; set; }
    public bool IsRechargeable { get; set; }
}
