using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_SystemIODirectoryIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //YeniKlasorOlustur("c://NetworkAkademi");
            KlasorVarlikKontrolu("c:\\NetworkAkademi");
            
            //KlasorSilmeIslemleri("c:\\NetworkAkademi");
            //KlasorTasimaIslemleri("c:\\NetworkAkademi", "c:\\TasimaIslemi\\NetworkAkademi");
            Console.ReadKey();
        }

        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo DI = Directory.CreateDirectory(path);
        }

        static void KlasorVarlikKontrolu(string path)
        {
            bool kontrol = Directory.Exists(path);
            if (kontrol==false)
            {
                Console.WriteLine("Klasör oluşturuluyor...");
                YeniKlasorOlustur("c://NetworkAkademi");
            }
            else
            {
                Console.WriteLine("Bu isim de bir klasör zaten bulunuyor.Eskisinin silinip yeni bir klasör oluşturulmasını istiyor musunuz? E/H");
                string cevap = Console.ReadLine();
                if (cevap=="E")
                {
                    Console.WriteLine("Silme işlemi gerçekleşiyor...");
                    Console.WriteLine("Yeni dosya oluşturuluyor...");
                    YeniKlasorOlustur("c://NetworkAkademi");
                }
                else if (cevap=="H")
                {
                    Console.WriteLine("İsteğiniz üzerine dosya silinmedi ve yeni klasör oluşturulmadı...");
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                }
            }
            Console.WriteLine(kontrol); 
        }

        static void KlasorSilmeIslemleri(string path)
        {
            Directory.Delete(path,true);
        }

        static void KlasorTasimaIslemleri(string kaynak,string hedef)
        {
            Directory.Move(kaynak, hedef);
        }

        static void Odev1()
        {
            /*
             * C sürücüsü içinde NetworkAkademi adında bir klasör oluşturun oluşturmadan önce varlık kontrolü yapın eğer klasör var ise silin silerken yine kullanıcıdan silmek istiyor musunuz diye E/H ile kontrol sağlayın daha sonra oluşturun.Eğer klasör yok ise oluşturun fakat adımların bilgisini ekrana yazdırın. 
             */
        }

        
    }
}
