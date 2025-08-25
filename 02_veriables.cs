using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            // Double Değişkenler
            double number;
            number = 4.87;
            Console.WriteLine(number);
            // burda araya konan nokta cmd ekranında virgül olarak çıktı verir.

            double elmaKilo, havucKilo, cilekKilo, patatesKilo, domatesKilo;
            elmaKilo = 14.85;
            havucKilo = 20.95;
            cilekKilo = 45;
            patatesKilo = 9.74;
            domatesKilo = 6.88;

            Console.WriteLine("----- Fiyat Listesi -----");
            Console.WriteLine();
            Console.WriteLine("----- Elma Birim Fiyatı:" + elmaKilo);
            Console.WriteLine("----- Havuç Birim Fiyatı:" + havucKilo);
            Console.WriteLine("----- Çilek Birim Fiyatı:" + cilekKilo);
            Console.WriteLine("----- Patates Birim Fiyatı:" + patatesKilo);
            Console.WriteLine("----- Domates Birim Fiyatı:" + domatesKilo);
            Console.WriteLine(); Console.WriteLine();

            // Kaçar gram alınacak? :
            double elmaGram, havucGram, cilekGram, patatesGram, domatesGram;
            elmaGram = 1.245;
            havucGram = 2.650;
            cilekGram = 0.750;
            patatesGram = 4.859;
            domatesGram = 3.745;

            double elmaToplam = elmaGram * elmaKilo;
            double havucToplam = havucGram * havucKilo;
            double cilekToplam = cilekGram * cilekKilo;
            double patatesToplam = patatesGram * patatesKilo;
            double domatesToplam = domatesGram * domatesKilo;

            Console.WriteLine("Elma birim fiyatı: " + elmaKilo + " *** alınan elma miktarı: " + elmaGram + " *** toplam elma fiyatı:" + elmaToplam);
            Console.WriteLine("Havuç birim fiyatı: " + havucKilo + " *** alınan havuç miktarı: " + havucGram + " *** toplam havuç fiyatı:" + havucToplam);
            Console.WriteLine("Çilek birim fiyatı: " + cilekKilo + " *** alınan çilek miktarı: " + cilekGram + " *** toplam çilek fiyatı:" + cilekToplam);
            Console.WriteLine("Patates birim fiyatı: " + patatesKilo + " *** alınan patates miktarı: " + patatesGram + " *** toplam patates fiyatı:" + patatesToplam);
            Console.WriteLine("Domates birim fiyatı: " + domatesKilo + " *** alınan domates miktarı: " + domatesGram + " *** toplam domates fiyatı:" + domatesToplam);
            Console.WriteLine(); Console.WriteLine();

            double toplamTutar = elmaToplam+havucToplam+cilekToplam+patatesToplam+domatesToplam;
            Console.WriteLine("Toplam tutar: " + toplamTutar);
            #endregion

            #region Char Değişkenler
            // ABCDEFGH
            // DEF 
            // Sezar Algoritması +3
            // Charlar tek tek harfleri ele almamız gerektiğinde kullanılır
            // tek tırnak içinde tanımlanır 

            char karakter;
            karakter = 'a';
            Console.WriteLine(karakter);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            Console.WriteLine("*** C# Hava Yolları Yolcu Bilgisi ***");
            string musteriAdi, musteriSoyadi, musteriSehir, musteriYas, musteriTc;
            // bunları klavyeden almak için;

            Console.Write("Yolcu Adı: ");
            musteriAdi= Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            musteriSoyadi = Console.ReadLine();

            Console.Write("Yolcu Sehir: ");
            musteriSehir = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            musteriYas = Console.ReadLine();

            Console.Write("Yolcu Tc No: ");
            musteriTc = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("------------------------");
            Console.WriteLine(
                "Yolcu Tc No: "+musteriTc+" "+
                "Yolcu Ad Soyad: " + musteriAdi +" " + musteriSoyadi+" "+
                "Yolcu Şehir: "+musteriSehir+" "+
                "Yolcu Yaş: "+" "+musteriYas
                );



            #endregion

            #region Klavyeden İnteger Girişleri ve Dönüşümler

            // C# başta girilen değerleri string olarak algılar
            // bunun olmaması girilen sayının integer olarak 
            // algılanması için bizim dönüşüm yapmamız gerekir
            // girilen şeyi stringden integer'a dönüştürmemiz gerekiyor
            // girilen şeyin sayı olduğunu bana belirt diyor C#

             int ayakkabiFiyati, bilgisayarFiyati, sandalyeFiyati, tvFiyati;
            ayakkabiFiyati = 1000;
            bilgisayarFiyati = 20000;
            sandalyeFiyati = 5000;
            tvFiyati = 12000;

            int ayakkabiSayisi, bilgisayarSayisi, sandalyeSayisi, tvSayisi;
            
            Console.Write("Aldığınız ayakkabı sayısını giriniz: ");
            ayakkabiSayisi = int.Parse(Console.ReadLine());

            Console.Write("Aldığınız bilgisayar sayısını giriniz: ");
            bilgisayarSayisi = int.Parse(Console.ReadLine());

            Console.Write("Aldığınız sandalye sayısını giriniz: ");
            sandalyeSayisi = int.Parse(Console.ReadLine());

            Console.Write("Aldığınız tv sayısını giriniz: ");
            tvSayisi = int.Parse(Console.ReadLine());

            int toplamFiyat = (
                ayakkabiFiyati * ayakkabiSayisi +
                bilgisayarFiyati * bilgisayarSayisi +
                sandalyeSayisi * sandalyeFiyati +
                tvFiyati * tvSayisi
                );

            Console.WriteLine("Toplam tutar: " + toplamFiyat);

            // pars dönüşüm için kullanılan bir method 

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            
            double sınav1, sınav2, sınav3, ortalama;

            Console.Write("1. Sınav Notunuzu Giriniz: ");
            sınav1= double.Parse(Console.ReadLine());

            Console.Write("2. Sınav Notunuzu Giriniz: ");
            sınav2 = double.Parse(Console.ReadLine());

            Console.Write("3. Sınav Notunuzu Giriniz: ");
            sınav3 = double.Parse(Console.ReadLine());

            ortalama = (sınav1 + sınav2 + sınav3) / 3;

            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: "+ortalama);

            // kodlamada ondalıklı girerken nokta koyarız
            // cmd'de noktalı girerken virgül koyarız 
            #endregion

            #region Klavyeden Karakter Girişleri

            
             char cinsiyet;
             Console.Write("Lütfen Cinsiyet Seçiniz: ");
             cinsiyet = char.Parse(Console.ReadLine());
             Console.WriteLine();
             Console.WriteLine("Cinsiyetiniz :" + cinsiyet);
            

            #endregion

            Console.Read();
        }       
    }
}
