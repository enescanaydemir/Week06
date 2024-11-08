using System;

namespace StoreProductManagementApplication;

public class Product
{
    public Product(string name, double price, int stockQuantity)
    {
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public string Name { get; set; }
    public double Price { get; set; }
    public int StockQuantity { get; set; }

    public int CheckStock()
    {
        return StockQuantity;
    }

    public int UpdateStock()
    {
        return StockQuantity;
    }
}


/*
Bir Product (Ürün) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:

Name (isim): Ürün adı
Price (fiyat): Ürün fiyatı
StockQuantity (stok miktarı): Ürün stok miktarı
Product sınıfına CheckStock (Stoku Kontrol Et) ve UpdateStock (Stok Güncelle) metodlarını ekleyin. FoodProduct (Gıda Ürünü) ve ElectronicProduct (Elektronik Ürün) gibi türemiş sınıflar oluşturun ve her sınıfa spesifik özellikler ekleyin (örneğin, FoodProduct için ExpirationDate (Son Kullanma Tarihi)).

*/