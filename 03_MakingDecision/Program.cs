using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else Karar yapıları
            //Console.Write("Lütefen Şifreyi Giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "ABCD")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");

            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğru");
            //}
            //else
            //{
            //    Console.Write("veriler yanlış");
            //}
            //Console.Read();

            //int number;
            //Console.Write("Bir Sayı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result ="Hata";
            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunu Giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notunu Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine("Sonuç: " + result);

            //string city;
            //Console.Write("Şehir Adını Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcuttur.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değildir.");
            //}

            //Console.Write("Kullanıcı Adını Giriniz: ");
            //string usuruname = Console.ReadLine();
            //if (usuruname != "admin")
            //{
            //    Console.Write("Bu kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş Geldiniz.");
            //}

            #endregion

            #region Mode İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine("Sonuç: " + result);

            //Console.Write("Lütfen 1.sayıyı Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sayıyı Sayı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number % number2;
            //Console.WriteLine("1 sayının 2 sayıya bölümünden kalan: " + result); //kalanları bulur


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{ 
            //    Console.Write("Sayı çiftir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if(team == 'G' | team == 'g' )
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{ 
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if(team == 'b' | team =='B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("böyle bir değişken yoktur");

            //}
            #endregion
            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** c# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Ana Yemekler---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Fırın Makarna");
            //    Console.WriteLine("3- Kıymalı Pide");
            //    Console.WriteLine("4- Kuzu Tandır");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("---------------Ana Yemekler---------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Çorbalar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Tarhana Çorbası");
            //    Console.WriteLine("3- Tavuk Suyu Çorbası");
            //    Console.WriteLine("4- Sebze Çorbası");
            //    Console.WriteLine("5- Ezogelin Çorbası");
            //    Console.WriteLine("---------------Çorbalar---------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Pizzalar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margaritha");
            //    Console.WriteLine("3- Tavuklu Pizza");            
            //    Console.WriteLine("---------------Çorbalar---------------");
            //    Console.WriteLine();
            //}
            //if(menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------İçecekler---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Ayran");
            //    Console.WriteLine("2- Kola");
            //    Console.WriteLine("3- Fanta");
            //    Console.WriteLine("4- Limonata");
            //    Console.WriteLine("5- Şalgam");
            //    Console.WriteLine("---------------İçecekler---------------");
            //    Console.WriteLine();
            //}
            //if(menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Tatlılar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kadayıf");
            //    Console.WriteLine("2- Baklava");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine("4- Profiterol");
            //    Console.WriteLine("5- İrmik Helvası");
            //    Console.WriteLine("---------------Tatlılar---------------");
            //    Console.WriteLine();
            //}
            ////else
            ////{
            ////    Console.WriteLine("Böyle bir menü seçeneği yoktur.");
            ////}
            #endregion
            #region Switch Case Karar Yapıları
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default:Console.Write("Böyle bir ay yoktur."); break;
            //}

            #endregion
            #region Switch Case Hesap Makinesi Uygulama
            int number1, number2, result;
            char symbol;
            Console.Write("1.Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Yapmak İstediğiniz İşlemi Giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2; Console.WriteLine("Toplam: " + result); break;
                case '-':
                    result = number1 - number2; Console.WriteLine("Çıkarma: " + result); break;
                case '*':
                    result = number1 * number2; Console.WriteLine("Çarpma: " + result); break;
                case '/':
                    result = number1 / number2; Console.WriteLine("Bölme: " + result); break;
                default: Console.WriteLine("Böyle bir işlem yoktur."); break;

            }
            #endregion

            Console.Read();
        }
    }
}
