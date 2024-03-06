namespace ConsoleAppOdev5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan sayı girmesini istedik
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //IsPerfectNumber fonksiyonundan dönen değer true ise bilgiyi yazdırdık
            if (IsPerfectNumber(number))
            {
                Console.WriteLine($"{number} is a perfect  number !");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect number !");
            }


        }

        //Girilen sayının mükemmel olup olmadığının kontrolünü bu fonksiyon içinde yaptık
        static bool IsPerfectNumber(int num)
        {
            int total = 0;
            //Bu döngü i'den başlayarak sayının bir önceki değerine kadar olan sayıları kontrol edip pozitif bölenleri kontrol eder.
            for (int i = 1; i < num; i++)
            {
                //eğer num parametresin i ile bölümünden kalan 0 ise i değeri num parametresinin bir bölenidir. Bu yüzden total'e i değerini ekledik
                if (num % i == 0)
                {
                    total += i;
                }
            }

            return total == num;

        }
    }
}
