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
            List<string> list = new List<string>();

            while (true) 
            {
                Console.WriteLine("Lütfen davet etmek istediğiniz kişilerin isimlerini giriniz(İşleminiz bittiğinde 'q' yazınız.) : ");
                string invite = Console.ReadLine();

                if ( invite == "q")
                {
                    break;
                }

                list.Add(invite);
            }

            Console.WriteLine("\nDavetliletin listesi :");
            foreach (string guests in list)
            {
                Console.WriteLine(guests);
            }
            Console.ReadLine();
        }
    }
}
