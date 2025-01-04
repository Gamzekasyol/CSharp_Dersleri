namespace ConsoleApp1
{
    internal class Program
    {

        private bool durum()
        {
            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                return true;
            }
            else 
                return false;   
        }
        static void Main(string[] args)
        {
            Program program = new Program();
             bool sonuc = program.durum();
            Console.WriteLine("Sonuç: " + sonuc);
            Console.ReadLine();
        }
        
    }
    
}
