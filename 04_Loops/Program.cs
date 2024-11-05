using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //For(X;y;Z)
            //x: Başlangıç değeri
            //y: Bitiş değeri
            //z: Artış miktarı veya azalış miktarı

            //int i;
            //for( i = 1; i <=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı"); //ekrana 5 kere yazdırır.
            //}

            ////////////////////////////////////////////
            //for (int i = 1; i <=20; i++)
            //{
            //    Console.WriteLine(i);

            //}
            ///////////////////////////////////////////////
            //for (int i = 3; i <=50; i +=3) //3 er 3er artış yapıyor 
            //{
            //    Console.WriteLine(i);
            //}
            ///////////////////////////////////////////////

            //Console.Write("Lütfen Ekrana Yazılması istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion
            #region For Döngüsü İle Karar Yapıları
            //for(int i =0; i<=100; i++) /// beşe tam bölünen sayıları yazdırma
            //{
            //    if (i % 5 ==0)
            //    { 
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;
            //for (int i = 1; i <= 10; i++)
            //{

            //        totalvalue += i;

            //}
            //Console.WriteLine("Toplam Değer: " + totalvalue);

            //int totalvalue = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if(i %2 ==0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---------------");
            //Console.WriteLine("Toplam Değer: " + totalvalue);

            //int count = 0;
            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("7'ye tam bölünen sayı adedi: " + count);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saatteki bakteri sayısı: " + bacterium);
            //}

            #endregion

            #region While Döngüsü
            //While
            // {
            // İşlemler
            //}

            //int i = 1;
            //while(i <=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            // 1 ile 10 arasındaki sayıların toplamını bulan program

            //int i = 1;
            //int sum = 0;

            //while (i<= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("Toplam Değer: " + sum);
            #endregion
            #region Örnek Sınav Sorusu
            // Klavyeden  girilen  3 basamaklı  sayının basamakları toplamını bulan program yazınız.
            //456

            ///////////////////////////////////////////
          

            //Console.Write("Sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10; // birler basamağını bulma
            //tens = (number % 100) / 10; // onlar basamağını bulma
            //hundreds = number / 100; //yüzler basamağını bulma
            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine("Basamaklar Toplamı: " + sum);
            #endregion
            Console.Read();
        }
    }
}
