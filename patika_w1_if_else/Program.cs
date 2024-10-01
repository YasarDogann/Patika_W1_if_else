using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz: ");
            string number = Console.ReadLine();
            int result = 0;

            //konsoldan alınan number tam sayıya dönüştürülür başarılı olursa result içine atanır.
            //eğer dönüşüm başarısız olursa result default değer atanacak.
            int.TryParse(number, out result);

            if (result > 10)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"Girilen Sayı 10'dan büyük ve Çift Bir Sayıdır: {result}");
                }
                else
                {
                    Console.WriteLine($"Girilen Sayı 10'dan Büyük Tek bir Sayıdır: {result}");
                }
            }
            else if (result < 10)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"Girilen Sayı 10'dan Küçük Çift Bir Sayıdır: {result}");
                }
                else
                {
                    Console.WriteLine($"Girilen Sayı 10'dan Küçük Tek bir Sayıdır: {result}");
                }
            }
            else
            {
                Console.WriteLine("Sayı 10'a Eşittir.");
            }

            Console.ReadKey();
        }
    }
}