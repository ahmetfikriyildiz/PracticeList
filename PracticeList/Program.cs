using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeList
{
    public class Program
    {
        static void Main(string[] args)
        {
            // String türünde bir liste oluşturuyoruz; bu listeye davetli isimlerini ekleyeceğiz
            List<string> list = new List<string>();

            // Sonsuz bir döngü başlatıyoruz, kullanıcıdan isim almak için
            while (true)
            {
                // Kullanıcıya isim girmesi veya işlemi bitirmesi için talimat veriyoruz
                Console.Write("Lütfen davet etmek istediğiniz kişilerin isimlerini giriniz (İşleminiz bittiğinde 'q' yazınız): ");

                // Kullanıcının girdiği ismi "invite" değişkenine atıyoruz
                string invite = Console.ReadLine();

                // Eğer kullanıcı 'q' yazdıysa döngüden çıkıyoruz
                if (invite == "q")
                {
                    break; // Döngüyü sonlandır
                }

                // Kullanıcının girdiği ismi listeye ekliyoruz
                list.Add(invite);
            }

            // Davetlilerin listesini ekrana yazdırıyoruz
            Console.WriteLine("\nDavetlilerin listesi:");

            // Listedeki her ismi tek tek ekrana yazdırmak için foreach döngüsü kullanıyoruz
            foreach (string guest in list)
            {
                Console.WriteLine(guest); // Her davetliyi ekrana yazdır
            }

            // Kullanıcı, ekrana basılan listeyi görebilsin diye programın kapanmasını engelliyoruz
            Console.ReadLine();

        }
    }
}
