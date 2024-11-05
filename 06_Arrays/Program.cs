using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            // 2 4 6 8 
            // Sarı Kırmız  Mavi Yeşil
            // Adana Ankara İstanbul İzmir
            // DeğişkenTürü[] DiziAdı = new DeğişkenTürü[ElemanSayısı]


            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[0]); // kırmızı çektim burda 


            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Berlin";
            //cities[3] = "Paris";
            //cities[4] = "Londra";
            //Console.WriteLine(cities[4]); // Paris yazdırır


            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[7]); //748 yazdırır olmayan dizi tanımını çağırırsam 0 olarak döner

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara","Bursa" }; //0dan başlar
            //Console.WriteLine(cities[3]); //Ankara yazdırır


            #endregion

            #region Dizideki tüm elemanları listeleme
            //string[] colors = { "Kırmızı", "Sarı", "Beyaz", "Mavi","Yeşil","Turuncu","Pembe" };
            //for(int i = 0; i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 4, 85, 96, 75, 124, 635, 488, 522, 7456, 2365, 1120 };
            //for (int  i = 0;  i <numbers.Length;  i++)
            //{
            //    if(numbers[i] % 3 == 0)//3 e tam bölünen sayıları yazdırma
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}


            //char[] symbols = {'a','b','c','*','/','-'}; // sadece tek tırnak kullanmak önemli
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = {47,85,95,41,25,635,789,86,100};
            //int maxNumber = myArray[0];
            //for (int i = 0; i< myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)// en büyük sayıyı bulma
            //    {
            //        maxNumber = myArray[i];// en büyük sayıyı bulma
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = {"ali","ahmet","ayşe", "buse","cem", "deniz" };
            //Console.WriteLine("Dizi Uzunluğu: " + persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);//numbers dizisini sıralama
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);//numbers dizisini sıralama   ///Reverse diziyi tersten sıralamaya yarıyor 
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Methodları
            //string[] customers = { "Ali", "buse","ayşegül","merve","çınar", "kaya"};
            //int index = Array.IndexOf(customers, "merve");//ayşegülün indexini bulma
            //Console.WriteLine("Index: " + index);
            //#endregion
            //Console.Read();

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Console.WriteLine("Dizinin En büyük elemanı: " + numbers.Max() + " Dizinin En küçük Elemanı: " + numbers.Min());//86 nın indexini bulma
            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.  Şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for(int i = 0; i<numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            Console.WriteLine("çift Sayılar");
            Console.WriteLine();
            for(int i =0; i< numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    Console.WriteLine(numbers[i]);
                }
                
                
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
              

            }

            #endregion




            Console.Read();
        }
    }
}