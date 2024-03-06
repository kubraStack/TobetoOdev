namespace ConsoleAppOdev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Do-While Döngüsü :
            // Bir koşul kontrölüne dayanan tekrarlı bir işlem gerçekleştirmek içinkullanılan bir döngü yapısıdır

            int sayi;
            do
            {
                Console.Write("Lütfen 1 ile 5 arasında bir sayı giriniz: ");
            }
            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi < 1 || sayi > 5);
            //int.TryParse ile girilen bilgiyi tamsayıya çevirdik
            //eğer TryParse fonksiyonu başarılı olursa bilgiyi out parametresi ile sayi değişkenine atadık
            {
                Console.WriteLine($"Girilen Sayı: {sayi}");
            }


            // While Döngüsü
            // Belirli bir koşul doğru olduğu sürece bir bloğu tekrarlamak için kullanılan bir döngü yapısıdır.


            //Kullanıcıdan sayıyı alıp while ile girilen sayının faktöriyeli hesaplandı.
            Console.Write("Faktöriyeli hesaplamak için bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int faktoriyel = 1;
            int count = 1;

            while(count <= number)
            {
                faktoriyel *= count;
                count++;
            }

            Console.WriteLine($"{number}! = {faktoriyel}");
        }
    }
}
