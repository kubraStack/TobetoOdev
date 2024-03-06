namespace ConsoleAppOdev6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Metotları

            // 1-) Lenght Methodu => string bir ifadenin karakter sayısını(uzunluğunu) döndürür.

            string str = "Hello . My name is Kübra";
            int lenght = str.Length;
            Console.WriteLine(lenght);
            Console.WriteLine("--------------------------------");


            // 2-) ToUpper - ToLower
            // ToUpper metodu string bir ifadenin tüm karakterlerini büyük harfe dönüştürür.
            // ToLower metodu string bir ifadenin tüm karakterlerini küçük harfe dönüştürür.

            string text = "bmw";
            string text2 = "MERCEDES";

            string upperText = text.ToUpper();
            Console.WriteLine(upperText);

            string lowerText = text2.ToLower();
            Console.WriteLine(lowerText);
            Console.WriteLine("---------------------------------");

            // 3-) Contains Metodu => String ifadenin içinde aranan harf yada kelime var mı yok mu bakar. eğer varsa "True" yoksa "False" değer döner.

            string str2 = "Lorem ipsum dolor sit amet";
            bool isCorrect = str2.Contains("sit");
            Console.WriteLine(isCorrect);
            Console.WriteLine("---------------------------------");


            // 4-) EndsWith metodu string ifadenin en sonunda aranan kelime var mı yok mu ona bakar ve sonuç olarak True veya False değer döner.

            string address = "3519 Shobe Lane, Wiggins,  CO, Colorado";
            bool includedAddres = address.EndsWith("o");
            Console.WriteLine(includedAddres);
            Console.WriteLine("----------------------------------");

            // 5-) StartsWith metodu string ifadenin en başında aranan kelime var mı yok mu ona bakar ve sonuç olarak True veya False değer döner.

            string address2 = "3519 Shobe Lane, Wiggins,  CO, Colorado";
            bool includedAddres2 = address.StartsWith("3");
            Console.WriteLine(includedAddres2);
            Console.WriteLine("----------------------------------");

            // 6-) Insert(indexNo, "") => Bu metot sayesinde istediğimiz indexten sonrasına istediğimiz kelimeyi ekleyebiliriz.

            string text3 = "Ali is the most hardworking student in the class.";
            text3 = text3.Insert(3, ",");
            Console.WriteLine(text3);
            Console.WriteLine("----------------------------------");

            // 7-) Remove() metodu girilen index numarasından itibaren tüm karakterleri siler.
            // Eğer iki parametre girilirse ilk parametredeki index numarasından başlar diğer parametre kadar karakter siler

            string text4 = "Ankara is the capital of Türkiye....Türkiye is beautiful city";
            //text4 = text4.Remove(33);
            text4 = text4.Remove(33, 3);
            Console.WriteLine(text4);
            Console.WriteLine("----------------------------------");

            // 8-) Replace metodu iki parametre alır.İlk parametre değiştirmek istediğimiz karakteri, ikinci parametre ise olmasını istediğimiz karakteri alır.

            string bird = "Canary";
            bird = bird.Replace("Canary", "Eagle");
            Console.WriteLine(bird);
            Console.WriteLine("---------------------------------");

            // 9-) Substring metodu iki parametre alabilir.Tek parametre girilirse o değerden itibaren tüm karakteri alır.İki parametre girilirse ilk değerden başlar ikinci değer kadar karakter alır.

            string str3 = "Ali Güngör";
            //str3 = str3.Substring(2);
            str3 = str3.Substring(3, 3);
            Console.WriteLine(str3);
            Console.WriteLine("--------------------------------");

            // 10-) Split metodu bir dizeyi belirli bir ayırıcıya göre parçalamak için kullanılır.

            string originalStr = "Merhaba,Dünya,Nasılsın";
            char[] ayirici = { ',' };

            string[] splitedStr = originalStr.Split(ayirici);
            //Parçalanmış dize elemanlarına foreach ile dönüp her eleman partialStr değişkenine atılıp yazdırılır.
            foreach (string partialStr in splitedStr)
            {
                Console.WriteLine(partialStr);
            }
            Console.WriteLine("---------------------------------");


            // 11-) Trim metodu string değişkenin başındaki ve sonundaki boşlukları siler. TrimEnd veya TrimStart da kullanılabilir.

            string name = " Ali Bahtiyar ";
            name = name.Trim();
            Console.WriteLine(name);
            Console.WriteLine("---------------------------------");

            // 12-) Clone metodu string değişkeni ile oluşturduğumuz içeriğin bir klonunu oluşturarak kopyasını çıkarır.
            string text5 = "ElizAlyaDemir";
            string cText5 = (string)text5.Clone();
            Console.WriteLine(cText5);
            Console.WriteLine("-------------------------------");

            // 13-) IndexOf metodu string değişkenin içinde aradığımız karakterin konumunu verir.

            string text6 = "Kırmızı";
            Console.WriteLine(text6.IndexOf('ı'));
            Console.WriteLine("--------------------------------");

            // 14-) PadRight metodu değişkenin sağına verilen sayıdan metnin uzunluğu çıkartılarak o kadar istenen karakter eklenir,
            // PadLeft metodu değişkenin soluna verilen sayıdan metnin uzunluğu çıkartılarak o kadar istenen karakter eklenir.

            string metin = "LeylaGüven ";
            Console.WriteLine(metin.PadRight(14, 'a'));
            Console.WriteLine(metin.PadLeft(14, 'a'));
            Console.WriteLine("--------------------------------");


        }

    }
}
