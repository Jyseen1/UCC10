internal class Program
{
    private static void Main(string[] args)
    {

        #region if-else blogu
        // belirli bir kosulun saglanmasi durumunda  belirli komutlar,diger durumda da baska komutlarin caslismasi durumu
        //int sayi1, sayi2;
        ////// buyukluk kucukluk
        //Console.WriteLine("Lutfen 1.sayiyi giriniz : ");

        //sayi1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Lutfen 2.sayiyi giriniz : ");

        //sayi2 = Convert.ToInt32(Console.ReadLine());

        // if (sayi1 < sayi2)
        //{
        //kosul dogru oldugunda calisacak bolum burasi
        //  Console.WriteLine("sayil degerim sayi2 degerinden kucuk...1.sayi : {0} - 2.sayi : {1}",sayi1,sayi2);
        //}

        //else if (sayi1 > sayi2) 
        //{
        //yanlis oldugunda burasi calisacak
        //  Console.WriteLine("sayil degerim sayi2 degerinden buyuk...1.sayi : {0} - 2.sayi : {1}", sayi1, sayi2);
        //}

        // else
        //   {
        //         Console.WriteLine("sayil degerim sayi2 degerine esittir...1.sayi : {0} - 2.sayi : {1}", sayi1, sayi2);
        //       }


        // switch esdegeri

        //switch (sayi1 < sayi2)
        //{
        //    case true:
        //        Console.WriteLine("Sayi1 kucuk sayi2");
        //        break;

        //        case false:
        //        Console.WriteLine("sayi1 buyuk sayi2");
        //        break;

        //        // esitlik durumu icin..
        //    default:
        //        Console.WriteLine("Sayi1 esit sayi2");
        //        break;
        //}


        #endregion

        #region for
        //1 den 20 ye kadar olan saiylari toplami 

        int toplam=0;
        for (int sayi = 0; sayi <= 100; sayi += 3)
        {
            Console.WriteLine(sayi);
            toplam += sayi;
        }
       

        Console.WriteLine("toplam :"+toplam);
        //









        #endregion

        

        Console.ReadLine();
    }
}