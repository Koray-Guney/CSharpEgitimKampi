using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05__LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta  10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana  10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion


            #region Alt alta  10 tane yıldız oluşturma her satırda 10 tane yıldız olacak

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion


            #region Her Satırda dik üçgen oluşturma

            //for(int i = 1; i <=5; i++)
            //  {
            //      for(int m = 1; m <= i; m++)
            //      {
            //          Console.Write("*");
            //      }
            //      Console.WriteLine();
            //  }


            #endregion

            #region Her Satırda Ters dik üçgen oluşturma

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int m = 1; m <= i; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Dik ve Ters Dik Üçgeni Birleştirme

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int m = 1; m <= i; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion


            #region Baklava Dilimi oluşturma
            //// üst kısım
            //int n = 5;//kaç satırfan oluştuğunu belirledi
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--) // sol taraftan boşluk bırakmak
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////alt kısım 
            //for (int i = n - 1; i >= 1; i--)// n 4 olarak başlayabilir.
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Piramit oluşturma
            // int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    /// burası boşluklar için
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    /// burası yıldızlar için
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Ters piramit
            int n = 5;
            for (int i = n; i >= 1; i--)
            { 
                // boşluklar için
                for(int j = n - i; j > 0; j--)
                {
                 Console.Write(" ");
                }

                // yıldızlar için
                for (int k = 1; k <= 2* i - 1; k++)
                {
                 Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            Console.Read();

        }

    }
}
