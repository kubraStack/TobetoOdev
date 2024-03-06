namespace ConsoleAppOdev7
{
    internal class Program
    {
        static void Main(string[] args){
            
            Console.Write("Lütfen öğrenci sayısını giriniz: ");
            int studentNumber = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= studentNumber; i++)
            {
                Console.Write("Lütfen öğrenci adını giriniz: ");
                string studentName = Console.ReadLine();

                Console.Write("Lütfen öğreci soyadını giriniz: ");
                string studentSurname = Console.ReadLine();

                Console.Write("Lütfen 1. Sınav notunu giriniz: ");
                int s1 = int.Parse(Console.ReadLine());

                Console.Write("Lütfen 2. sınav notunu giriniz: ");
                int s2 = int.Parse(Console.ReadLine());

                Console.Write("Lütfen 3. Sınav notunu giriniz: ");
                int s3 = int.Parse(Console.ReadLine());


                double gradeAverage = (s1 + s2 + s3) / 3;
                if (gradeAverage > 100)
                {
                    Console.WriteLine("Lütfen sınav notlarını kontrol ediniz. Sınav Notları İki Basamaklı Olmalıdır !");
                }
                else
                {
                    Console.WriteLine($"Öğrencinin not ortalaması : {gradeAverage}");
                }
                
            }

            




        }
    }
}
