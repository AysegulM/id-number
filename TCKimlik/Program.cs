using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCKimlik

{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Kimlik numaranızı giriniz: ");
            string girilen = Console.ReadLine(); //Enter tuşuna basılana kadar girilen tüm karakterleri birleştirip verir.
            //TryParse: Diğer veri tiplerinin ilgili ilkel(primitive) veri tipine dönüşmesi için kullanılan, dönüşüm başarılıysa True, başarısız ise False ve çıkış olarak da ilgili veri tipinin başlangıç değerini veren bir fonksiyondur. 
            bool donustu_mu = long.TryParse(girilen, out long cikan);
            if (donustu_mu)
            {
                //if (10000000000 <= cikan && 100000000000 > cikan)
                if (cikan.ToString().Length == 11)
                {
                    long ilk9 = cikan / 100;//Son iki hane atılır.
                    long son2 = cikan % 100;//Son iki hane kalan olarak alınır.
                    long tek_toplam = 0, cift_toplam = 0;

                    //123456789

                    //9. Basamak
                    long b9 = ilk9 % 10;
                    tek_toplam += b9;
                    ilk9 /= 10; //ilk9 = ilk9 / 10

                    //8.Basamak
                    long b8 = ilk9 % 10;
                    cift_toplam += b8;
                    ilk9 /= 10;

                    //7. Basamak
                    long b7 = ilk9 % 10;
                    tek_toplam += b7;
                    ilk9 /= 10; //ilk9 = ilk9 / 10

                    //6. Basamak
                    long b6 = ilk9 % 10;
                    cift_toplam += b6;
                    ilk9 /= 10;

                    //5. Basamak
                    long b5 = ilk9 % 10;
                    tek_toplam += b5;
                    ilk9 /= 10; //ilk9 = ilk9 / 10

                    //4. Basamak
                    long b4 = ilk9 % 10;
                    cift_toplam += b4;
                    ilk9 /= 10;

                    //3. Basamak
                    long b3 = ilk9 % 10;
                    tek_toplam += b3;
                    ilk9 /= 10; //ilk9 = ilk9 / 10

                    //2. Basamak
                    long b2 = ilk9 % 10;
                    cift_toplam += b2;
                    ilk9 /= 10;

                    //1. Basamak
                    long b1 = ilk9 % 10;
                    tek_toplam += b1;
                    ilk9 /= 10; //ilk9 = ilk9 / 10

                    long b10 = (tek_toplam * 7 - cift_toplam) % 10;
                    //b10 = ((b1 + b3 + b5 + b7 + b9) * 7 - (b2 + b4 + b6 + b8)) % 10;
                    long b11 = (tek_toplam + cift_toplam + b10) % 10;
                    //b11 = (b1 + b3 + b5 + b7 + b9 + b2 + b4 + b6 + b8 + b10) % 10;

                    if (son2 == b10 * 10 + b11)
                    {
                        Console.WriteLine("Tutarlıdır.");
                    }
                    else
                    {
                        Console.WriteLine("Tutarsızdır.");
                    }
                }
                else
                {
                    Console.WriteLine("Girdiğiniz kimlik numarası 11 hane değildir!");
                }
            }
            else
            {
                Console.WriteLine("Sayısal bir değer girmediniz!");
            }
        }
    }
}
