namespace ConsoleAppOdev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random class'ından bir random oluşturduk ve Next methodu ile 1 - 10 arasında sayı ürettik.
           Random random = new Random();
            int numberRange = random.Next(1, 11); // 1 ile 10 arasında tahminde bulunacağı için Next ile üretilecek sayı değerleri aralığını belirledik.


            //Kullanıcıdan isteyeceğimiz sayıyı tahmin olarak tanımladık. 
            // tahminSayısını da kullanıcının tahmin sayısını arttırmak için 0 ile tanımladık
            int forecast;
            int forecastNumber = 0;

            Console.Write("Please enter a number between 1 and 10:  ");

            
            while (true)
            {
                //Kullanıcının girdiği sayıyı tahmin değişkenine atadık
                //Her girişte tahmin sayısını arttırdık
                forecast = Convert.ToInt32(Console.ReadLine());
                forecastNumber++;

                //Eğer tahmin ile tahmin aralığından gelen sayı doğru ise kullanıcıyı bilgilendirip yanlış ise tekrar denemesini istedik
                if (forecast == numberRange)
                {
                    Console.WriteLine($"Congratulations your prediction {forecastNumber}  is correct !");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect prediction. Try again: ");
                }
            }

        }
    }
}
