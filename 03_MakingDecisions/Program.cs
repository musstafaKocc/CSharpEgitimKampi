using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Şifrenizi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //Console.WriteLine();

            //if (password == "123987")
            //{
            //    Console.Write("Şifre doğru.");
            //}
            //else
            //{
            //    Console.Write("Şifre yanlış.");
            //}

            //Console.Write("Başkentinizi giriniz: ");
            //string capital;
            //capital = Console.ReadLine();

            //TextInfo myTextInfo = new CultureInfo("tr-TR", false).TextInfo;
            //capital = capital.ToLower();
            //// ToTitleCase fonskiyonu;
            //// bazen büyük harfleri doğru işleyemeyebiliyor.
            //capital = myTextInfo.ToTitleCase(capital);

            //if (capital == "Ankara")
            //{
            //    Console.WriteLine("\nDoğru"); 
            //}
            //else
            //{
            //    Console.WriteLine("\nYanlış");
            //}

            //int number = 0;

            //while (number != 5)
            //{
            //    Console.Write("Bir sayı giriniz: ");
            //    number = int.Parse(Console.ReadLine());

            //    if (number == 5)
            //    {
            //        Console.WriteLine("\nGirdiğiniz sayı doğru.");
            //        Console.Write('\n');
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("\nGirdiğiniz sayı yanlış");
            //        Console.Write('\n');
            //    }
            //}

            //int exam1, exam2, exam3;
            //double average;
            //string result;

            //Console.Write("İlk sınav notunuzu giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sınav notunuzu giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Üçüncü sınav notunuzu giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.Write("\n");
            //Console.WriteLine("Ortalamanız: " + average);

            //if (average > 0 & average < 50)
            //{
            //   Console.Write("Sonuç: Başarısız");
            //}
            //else if (average >= 50 & average < 60)
            //{
            //    Console.Write("Sonuç: Geçer");
            //}
            //else if (average >= 60 & average < 70)
            //{
            //    Console.Write("Sonuç: Orta");
            //}
            //else if (average >= 70 & average < 85)
            //{
            //    Console.Write("Sonuç: İyi");
            //}
            //else if (average >= 85 & average < 90)
            //{
            //    Console.Write("Sonuç: Pekiyi");
            //}
            //else if (average >= 90 & average <= 100)
            //{
            //    Console.Write("Sonuç: Mükemmel");
            //}
            //else
            //{
            //    Console.Write("Sonuç: Geçersiz");
            //}

            //string city;
            //Console.Write("Şehir ismi giriniz: ");
            //city = Console.ReadLine();

            //TextInfo myTextInfo = new CultureInfo("tr-TR", false).TextInfo;
            //city = myTextInfo.ToTitleCase(city.ToLower());

            //if (city == "Ankara" | city == "İstanbul" | city == "Çanakkale")
            //{
            //    Console.WriteLine("\nSeçtiğiniz şehir sistemimizde mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("\nSeçilen şehir mevcut değil.");
            //}

            //Console.Write("Kullanıcı adınızı giriniz: ");
            //string username;
            //username = Console.ReadLine();
            //username = username.ToLower();

            //if (username != "admin")
            //{
            //    Console.Write("\nGeçersiz kullanıcı adı girdiniz.");
            //}
            //else
            //{
            //    Console.Write("\nHoşgeldiniz.");
            //}

            #endregion

            #region Mod işlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.Write(result);

            //Console.WriteLine("Mod hesaplayıcıya hoşgeldiniz.");
            //Console.Write("\n1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("\n1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.Write("\nSayı çifttir.");
            //}
            //else
            //{
            //    Console.Write("\nSayı tektir.");
            //}

            #endregion

            #region Örnek Uygulama
            //Console.Write("Takım sembolünü giriniz: ");
            //string symbol = Console.ReadLine();
            //symbol = symbol.ToUpper();

            //if (symbol == "GS")
            //{
            //    Console.WriteLine("\nTakım: Galatasaray");
            //}
            //else if (symbol == "FB")
            //{
            //    Console.Write("\nTakım: Fenerbahçe");
            //}
            //else if (symbol == "BJK")
            //{
            //    Console.Write("\nTakım: Beşiktaş");
            //}
            //else
            //{
            //    Console.Write("\nSembol sistemde mevcut değil.");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("*****C# Eğitim Kampı Restoran*****");
            //Console.Write("\n");
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------------");

            //Console.Write("Detaylı bilgi almak istediğiniz menü numarasını giriniz: ");
            //int input = int.Parse(Console.ReadLine());

            //switch(input)
            //{
            //    case 1:
            //        Console.WriteLine("\n****Ana Yemekler****");
            //        Console.WriteLine();
            //        Console.WriteLine("----------------------");
            //        Console.WriteLine("1. Adana Kebap");
            //        Console.WriteLine("2. Urfa Kebap");
            //        Console.WriteLine("3. İskender Kebap");
            //        Console.WriteLine("----------------------");
            //        break;
            //    case 2:
            //        Console.WriteLine("\n*****Çorbalar*****");
            //        Console.WriteLine();
            //        Console.WriteLine("--------------------");
            //        Console.WriteLine("1. Mercimek Çorbası");
            //        Console.WriteLine("2. Ezogelin Çorbası");
            //        Console.WriteLine("3. Domates Çorbası");
            //        Console.WriteLine("4. Tavuksuyu Çorbası");
            //        Console.WriteLine("--------------------");
            //        break;
            //    case 3:
            //        Console.WriteLine("\n*****Pizzalar*****");
            //        Console.WriteLine();
            //        Console.WriteLine("----------------------");
            //        Console.WriteLine("1. Margarita Pizza");
            //        Console.WriteLine("2. Sucuklu Pizza");
            //        Console.WriteLine("3. Karışık Pizza");
            //        Console.WriteLine("----------------------");
            //        break;
            //    case 4:
            //        Console.WriteLine("\n*****İçecekler*****");
            //        Console.WriteLine();
            //        Console.WriteLine("-------------------");
            //        Console.WriteLine("1. Ayran");
            //        Console.WriteLine("2. Su");
            //        Console.WriteLine("3. Gazoz");
            //        Console.WriteLine("4. Meyve Suyu");
            //        Console.WriteLine("5. Kola");
            //        Console.WriteLine("6. Fanta");
            //        Console.WriteLine("7. Soda");
            //        Console.WriteLine("-------------------");
            //        break;
            //    case 5:
            //        Console.WriteLine("\n****Tatlılar****");
            //        Console.WriteLine();
            //        Console.WriteLine("----------------------");
            //        Console.WriteLine("1. Baklava");
            //        Console.WriteLine("2. Kadayıf");
            //        Console.WriteLine("3. Künefe");
            //        Console.WriteLine("4. Sütlaç");
            //        Console.WriteLine("5. Trileçe");
            //        Console.WriteLine("----------------------");
            //        break;
            //    default:
            //        Console.Write("\nGeçersiz giriş yaptınız.");
            //        break;
            //}

            #endregion

            #region Switch-Case

            //Console.Write("Celp döneminizi giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //switch(number)
            //{
            //   case 1: Console.Write("\nCelp ayınız: Şubat"); break;
            //   case 2: Console.Write("\nCelp ayınız: Mayıs"); break;
            //   case 3: Console.Write("\nCelp ayınız: Ağustos"); break;
            //   case 4: Console.Write("\nCelp ayınız: Kasım"); break; 
            //}

            #endregion

            #region Switch-Case ile Hesap Makinesi

            //Console.Write("1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("İşlemi giriniz: ");
            //char islem = char.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result;

            //switch (islem)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.Write("\nToplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.Write("\nFark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.Write("\nÇarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.Write("\nBölüm: " + result);
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
