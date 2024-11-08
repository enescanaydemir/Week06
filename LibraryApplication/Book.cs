using System;

namespace LibraryApplication;

public class Book
{

    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public int ISBN { get; set; }



    public void Borrow()
    {

    }

    public void Return()
    {
        
    }
}


/*

    Bir Book (Kitap) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:

    Title (başlık): Kitap başlığı
    Author (yazar): Yazarın adı
    Pages (sayfa sayısı): Kitap sayfa sayısı
    ISBN (ISBN numarası): Kitap ISBN numarası

    Book sınıfına Borrow (Ödünç Al) ve Return (İade Et) metodlarını ekleyin. Daha sonra bir Library (Kütüphane) sınıfı oluşturun ve içinde bir dizi Book nesnesi tutarak bu kitapları yönetebilsin.

*/
