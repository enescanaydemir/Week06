using System;

namespace CalculatorApplication;

public class Calculator
{
    public Calculator(int add, int subtract, int multiply, int divide)
    {
        Add = add;
        Subtract = subtract;
        Multiply = multiply;
        Divide = divide;
    }


    public int Add { get; set; }
    public int Subtract { get; set; }
    public int Multiply { get; set; }
    public int Divide { get; set; }
}


/*

6. Hesap Makinesi (Calculator)
Bir Calculator (Hesap Makinesi) sınıfı oluşturun. Bu sınıf aşağıdaki işlemleri gerçekleştiren metodlar içermelidir:

Add (Topla)
Subtract (Çıkar)
Multiply (Çarp)
Divide (Böl)
Bu sınıftan ScientificCalculator (Bilimsel Hesap Makinesi) türetin ve içine Sin (Sinüs), Cos (Kosinüs) gibi ekstra fonksiyonlar ekleyin.



*/