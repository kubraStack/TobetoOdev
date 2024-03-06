namespace ConsoleAppOdev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan ürün adeti ve girilen ürünün fiyat bilgisini isteyip toplam tutar verildi.
            Console.WriteLine("Please enter how many products you want to buy:  ");
            int orderNumber = Convert.ToInt32(Console.ReadLine());

            double totalAmount = 0;

            for (int i = 1; i <= orderNumber; i++)
            {
                Console.WriteLine($"Enter the  price {i} of product: ");
                double productPrice = Convert.ToDouble(Console.ReadLine());

                totalAmount += productPrice;

            }

            Console.WriteLine($"Total shopping amount: {totalAmount}");
        }
    }
}
