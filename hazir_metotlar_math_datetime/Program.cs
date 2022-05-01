using System;

namespace hazir_metotlar_math_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datetime
            Console.WriteLine("Şu anda tarih : " + DateTime.Now); //Günün tarihini saniyeye kadar döndürür
            Console.WriteLine("Şu anda tarih : " + DateTime.Now.Date); //Günün tarihini döndürür
            Console.WriteLine("Şu anda ay : " + DateTime.Now.Month); // Ayı döndürür
            Console.WriteLine("Şu anda gün : " + DateTime.Now.Day); // Günü döndürür
            Console.WriteLine("Şu anda saat : " + DateTime.Now.Hour); // Saati döndürür
            Console.WriteLine("Şu anda dakika : " + DateTime.Now.Minute); // Dakikayı döndürür
            Console.WriteLine("Şu anda saniye : " + DateTime.Now.Second); // Saniyeyi döndürür
            Console.WriteLine(DateTime.Now.DayOfWeek); //Haftanın gününü döndürür
            Console.WriteLine(DateTime.Now.DayOfYear); //Yılın hangi günü olduğunu döndürür
            Console.WriteLine(DateTime.Now.ToLongTimeString()); //Uzun olarak zamanı döndürür
            Console.WriteLine("Şu anda tarih : " + DateTime.Now);
            Console.WriteLine("Şu andan 4 saat sonra : " + DateTime.Now.AddHours(4)); //Şu ana 4 saat ekler

            //Datetime Format
            //Day
            Console.WriteLine("Datetime Format");
            Console.WriteLine("Day Format");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("dd")); //24
            Console.WriteLine(DateTime.Now.ToString("ddd")); //PZT
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Pazartesi

            //Month
            Console.WriteLine("Month Format");
            Console.WriteLine(DateTime.Now.ToString("MM")); //05
            Console.WriteLine(DateTime.Now.ToString("MMM")); //May
            Console.WriteLine(DateTime.Now.ToString("MMMMM")); //Mayıs

            //Year
            Console.WriteLine("Year Format");
            Console.WriteLine(DateTime.Now.ToString("yy")); //23
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2023

            //Entire Format
            Console.WriteLine(DateTime.Now.ToString("dddd-MMMM-yyyy"));
            Console.WriteLine(DateTime.Now.ToString("dd,MMMM,yy"));


            //Math
            Console.WriteLine("Math Kütüphanesi");
            Console.WriteLine(Math.Abs(-25)); //Girilen sayının mutlak değerini döndürür
            Console.WriteLine(Math.Sin(30)); //Girilen değerin sinüs'ünü döndürür
            Console.WriteLine(Math.Cos(60)); //Girilen değerin cosinüs'ünü döndürür
            Console.WriteLine(Math.Tan(45)); //Girilen değerin Tanjant'ını döndürür

            Console.WriteLine(Math.Ceiling(22.3)); //Girilen double değeri bir üst sayıya yuvarlar
            Console.WriteLine(Math.Round(22.6)); //Girilen double değeri en yakın tam sayıya yuvarlar
            Console.WriteLine(Math.Round(22.4)); //Girilen double değerin en yakın tam sayıya yuvarlar
            Console.WriteLine(Math.Floor(22.7)); //Girilen dobule değerin bir aşağı sayıya yuvarlar

            Console.WriteLine(Math.Max(2, 5)); //Girilen sayı dizisi arasındaki en büyük sayıyı döndürür
            Console.WriteLine(Math.Min(2, 6)); //Girilen sayı dizisi arasındaki en küçük sayıyı döndürür

            Console.WriteLine(Math.Pow(2, 3)); //Birinci girilen değerin ikinci değer kadar üssünü döndürür
            Console.WriteLine(Math.Sqrt(25)); //Girilen değerin karekökünü alır

            Console.WriteLine(Math.Log(9)); //9'un e tabanındaki logaritmasını verir
            Console.WriteLine(Math.Exp(2)); //e^2 döndürür
            Console.WriteLine(Math.Log10(10)); //Girilen değerin 10 tabanında logaritmasını alır
            Console.ReadKey();
        }
    }
}
