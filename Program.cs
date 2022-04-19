using System;
using System.Collections;
using System.Collections.Generic;

namespace Odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Soru1 soru1 = new Soru1();
            soru1.Answer();
            Soru2 soru2 = new Soru2();
            soru2.Answer();
            Soru3 soru3 = new Soru3();
            soru3.Answer();
        }
    }

    class Soru1
    {
        public void Answer()
        {
            int asaltoplam =0;
            int nonasaltoplam =0;
            ArrayList asal = new ArrayList();
            ArrayList nonasal = new ArrayList();
            Console.WriteLine("20 adet pozitif sayı giriniz: ");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0} . sayıyı giriniz: ",i+1);
                
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    if(a > 0)
                    {
                        if(a == 1)
                        {
                            nonasal.Add(a);
                        }
                        else{
                            int kontrol = 0;
                            int x = 2;
                            while (x < a)
                            {
                                if (a % x == 0)
                                    kontrol++;
                                x++;
                            }
                            if (kontrol != 0)
                                nonasal.Add(a);
                            else
                                asal.Add(a);
                    }
                    }
                    else if(a <= 0)
                    {
                        Console.WriteLine("Pozitif bir sayı giriniz.");
                        i--;
                    }
                }
                catch (System.Exception)
                {
                    
                    Console.WriteLine("Geçerli bir sayı girmediniz. Lütfen sayı giriniz.");
                    i--;
                }
                
            }
                asal.Sort();
                nonasal.Sort();
                Console.WriteLine("{0} adet asal sayı yazdınız.",asal.Count);
                Console.WriteLine("{0} adet asal olmayan sayı yazdınız.",nonasal.Count);
                foreach (int item in asal)
                {
                    asaltoplam += item;
                }
                foreach (int item in nonasal)
                {
                    nonasaltoplam += item;
                }
                Console.WriteLine("Asal sayıların ortalaması: {0}",asaltoplam / asal.Count);
                Console.WriteLine("Asal olmayan sayıların ortalaması: {0}",nonasaltoplam/ nonasal.Count);
                foreach (var item in asal)
                {
                    Console.WriteLine(item);
                }
        }
    }

    class Soru2
    {
        public void Answer()
        {
            ArrayList sayilar = new ArrayList();
            ArrayList buyuk = new ArrayList();
            ArrayList kucuk = new ArrayList();
            
            int kucukort =0;
            int buyukort =0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0} . sayıyı giriniz: ",i+1);
                int girilenSayi = int.Parse(Console.ReadLine());
                try
                {
                    if(girilenSayi <= 0 || girilenSayi > 0)
                    {
                        sayilar.Add(girilenSayi);
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Lütfen sayı giriniz.");
                    i--;
                }
            }
            sayilar.Sort();
            for (int i = 0; i < 3; i++)
            {
                kucuk.Add(sayilar[i]);
                buyuk.Add(sayilar[(sayilar.Count-i)-1]);
            }
            kucuk.Sort();
            buyuk.Sort();
            
            foreach (int item in kucuk)
            {
                kucukort += item;
            }
            foreach (int item in buyuk)
            {
                buyukort += item;
            }
            kucukort = kucukort / kucuk.Count;
            buyukort = buyukort /buyuk.Count;
            Console.WriteLine("En küçük üç sayının ortalaması: "+kucukort);
            Console.WriteLine("En büyük üç sayının ortalaması: "+buyukort);
            Console.WriteLine("Büyük ve küçük sayıların ortalamasının toplamı: "+ (kucukort+buyukort));
        }
    }

    class Soru3
    {
        public void Answer()
        {
            Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Console.ReadLine().ToString();
            List<char> sesli = new List<char>();
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            foreach (var item in cumle)
            {
                foreach(var sesliharf in sesliler)
                {
                    if(item == sesliharf)
                    {
                        if(sesli.Contains(sesliharf))
                            break;
                        else
                            sesli.Add(item);
                    }
                }
            }
            Console.WriteLine("Cümledeki sesli harfler: ");
            foreach (var item in sesli)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
