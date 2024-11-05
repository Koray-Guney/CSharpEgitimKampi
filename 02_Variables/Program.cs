using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //// Variables
            ////double number;

            ////number = 4.85;

            ////Console.WriteLine(number);

            //Console.WriteLine("******** Fiyat Listesi *************");
            //Console.WriteLine();

            //double applePrice , orangePrice, strawberryPrice,potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("------ Elma Brim Fiyatı:" + applePrice + "TL");
            //Console.WriteLine("------ Portakal Brim Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("------ Çilek Brim Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("------ Patates Brim Fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("------ Domates Brim Fiyatı:" + tomatoPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine();
            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat:" + applePrice + " - Gramaj:" + appleGram + " - Toplam Tutar :" + appleTotalPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Portakal - " +"Birim Fiyat:"+ orangePrice +" - Gramaj:"+orangePrice+" - Toplam Tutar :" +orangeTotalPrice+"TL");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Çilek - " +"Birim Fiyat:"+ strawberryPrice +" - Gramaj:"+strawberryGram+" - Toplam Tutar :" +strawberryTotalPrice+"TL");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Portakal - " +"Birim Fiyat:"+ potatoPrice +" - Gramaj:"+potatoGram+" - Toplam Tutar :" +potatoTotalPrice+"TL");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Portakal - " +"Birim Fiyat:"+ tomatoPrice +" - Gramaj:"+tomatoGram+" - Toplam Tutar :" +tomatoTotalPrice+"TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();Console.WriteLine();Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "TL");


            #endregion
            #region Char Değişkenler (Karakter Değişenler)
            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00
            //// " ' = şeklinde tanımlanır.

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion
            #region Klavyeden Veri Girişleri  String Değişkenler
            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistirct, passengerCity,passengerAge , passengerIdentityNumber;
            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("İlçe Bilgisi:  ");
            //passengerDistirct = Console.ReadLine();
            //Console.Write("Şehir Bilgisi:  ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş:  ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Tc Kimlik Numarası:  ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Yolcu TC Kimlik No: "+ passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistirct + "/" + passengerCity + " " + passengerAge);

            #endregion
            #region Klavyeden  Tam Sayı Girişleri ve Dönüşümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen Aldığınız Ayakkabı Adedini Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice;
            //totalPrice = shoesCount * shoesPrice + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Alışveriş Tutarınız: " + totalPrice + "TL");
            #endregion
            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.Sınav Notunuzu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sınav Notunuzu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.Sınav Notunuzu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+result);
            #endregion
            #region Klavyeden Karakter Girişleri
            //char gender; // tek karaklterlik veri tutar.
            //Console.Write("Lütfen Cinsiyetinizi Seçiniz (E/K): ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion

            Console.Read();
        }
    }
}
