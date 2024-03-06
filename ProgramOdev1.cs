using System;

class Program
{
    static void Main()
    {
        //Müşteriden sipariş numarası alındı
        Console.Write("Please entered a order number: ");
        int orderNumber = Convert.ToInt32(Console.ReadLine());

        string orderProduct = SpecifyOrderProduct(orderNumber);

        //Girilen sipariş numarasının doğruluğu ve yanlışlığı kontrol edildi
        if (orderProduct != null)
        {
            Console.WriteLine("Ordered Product: " + orderProduct);
        }
        else
        {
            Console.WriteLine("Invalid Order Number ! Please entered valid order number.. ");
        }
    }

    //Girilen sipariş numarasına karşılık gelen ürünü switch - case kontrol yapısı ile elde etmek için yeni bir fonksiyon yazdık
    static string SpecifyOrderProduct(int orderNumber)
    {
        string product;

        switch (orderNumber)
        {
            case 1:
                product = "Computer";
                break;
            case 2:
                product = "Phone";
                break;
            case 3:
                product = "Camera";
                break;
            case 4:
                product = "Tablet"; 
                break;
            default:
                product = null; // Geçersiz sipariş numarası için
                break;
        }

        return product;
    }
}


