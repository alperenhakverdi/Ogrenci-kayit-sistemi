using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        public static int sayac = 0;
        public static string[] ogrencino = new string[5];
        public static string[] ogrenciadsoyad = new string[5];
        public static int[] vizenotlari = new int[5];
        public static int[] finalnotlari = new int[5];
        public static double[] ortalama = new double[5];





        static void Main(string[] args)
        {
            menusecimi();
            Console.ReadKey();
        }


        static void menusecimi()
        {
            menusec:
            Console.WriteLine("1: KAYIT EKLEME\n");
            Console.WriteLine("2: KAYIT DÜZELTME \n");
            Console.WriteLine("3: KAYIT SİLME \n");
            Console.WriteLine("4: KAYIT ARAMA \n");
            Console.WriteLine("5: KAYIT LİSTELEME \n");
            Console.WriteLine("6: ÇIKIŞ \n");
            Console.Write("SEÇİMİNİZİ YAPINIZ (1-6): \n");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Clear();
                    kayitekle();
                    break;
                case 2:
                    Console.Clear();
                    kayitduzelt();
                    break;
                case 3:
                    Console.Clear();
                    kayitsil();
                    break;
                case 4:
                    Console.Clear();
                    kayitara();
                    break;
                case 5:
                    Console.Clear();
                    kayitlistele();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    goto menusec;
                    break;
            }

        }

        static void kayitekle()
        {
            kayitdevam:
            Console.WriteLine("*** YENİ ÖĞRENCİ KAYIT İŞLEMLERİ ***");
            Console.Write("Öğrenci NO:");
            ogrencino[sayac] = Console.ReadLine();
            Console.Write("ADI SOYADI :");
            ogrenciadsoyad[sayac] = Console.ReadLine();
            Console.Write("VİZE NOTU : ");
            vizenotlari[sayac] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final NOTU : ");
            finalnotlari[sayac] = Convert.ToInt32(Console.ReadLine());

            double ort = (vizenotlari[sayac] * 4 / 10) + (finalnotlari[sayac] * 6 / 10);
            ortalama[sayac] = ort;
            Console.WriteLine("ORTALAMA : {0}",ortalama[sayac]);
            sayac++;

            Console.Write("Başka kayıt eklemek için E ve Enter tuşuna basınız.");
            string devam = Console.ReadLine();
            if (devam=="E")
            {
                Console.Clear();
                goto kayitdevam;
            }
            else
            {
                Console.Clear();
                menusecimi();
            }
            
        }

        static void kayitduzelt()

        {
            duzeltmedevam:
            Console.WriteLine("*** ÖĞRENCİ KAYIT DÜZELTME İŞLEMLERİ ");
            Console.Write("KAYIT DÜZELTMEK İSTEDİĞİNİZ ÖĞRENCİNİN NUMARASI : ");
            string numara = Console.ReadLine();
            int index = Array.IndexOf(ogrencino, numara);
            if (index!=-1)
            {
                Console.WriteLine("ÖĞRENCİ BİLGİLERİ : ");
                Console.WriteLine("ÖĞRENCİ NO : {0} ADI SOYADI : {1} VİZE NOTU : {2} FİNAL NOTU : {3} ORTALAMA {4} ",
                    ogrencino[index],ogrenciadsoyad[index],vizenotlari[index],finalnotlari[index],ortalama[index]);
                Console.Write("ADI SOYADI : ");
                ogrenciadsoyad[index] = Console.ReadLine();
                Console.Write("VİZE NOTU : ");
                vizenotlari[index] = Convert.ToInt32(Console.ReadLine());
                Console.Write("FİNAL NOTU : ");
                finalnotlari[index] = Convert.ToInt32(Console.ReadLine());
                double ort = (vizenotlari[index] * 4 / 10) + (finalnotlari[index] * 6 / 10);
                ortalama[index] = ort;
                Console.WriteLine("ORTALAMA : {0}", ort);

                Console.Write("BAŞKA KAYIT DÜZENLEMEK İÇİN E VE ENTER TUŞUNA BASINIZ");
                string devam = Console.ReadLine();
                if (devam=="E")
                {
                    Console.Clear();
                    goto duzeltmedevam;
                }
                else
                {
                    Console.Clear();
                    menusecimi();
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("{0} Numaralı öğrenci kayıtlı değildir!",numara);
                Console.WriteLine("Ana Menüye Dönmek için Bir tuşa basınız.");
                Console.ReadKey();
                Console.Clear();
                menusecimi();
            }

            
        }

        static void kayitsil()

        {
            sildevam:

            Console.WriteLine("*** ÖĞRENCİ KAYIT SİLME İŞLEMLERİ ***");
            Console.Write("SİLMEK İSTEDİĞİNİZ ÖĞRENCİNİN NUMARASI : ");
            string numara = Console.ReadLine();
            int index = Array.IndexOf(ogrencino, numara);
            if (index!=-1)
            {
                Console.WriteLine("ÖĞRENCİ NO : {0} ADI SOYADI : {1} VİZE NOTU : {2} FİNAL NOTU : {3} ORTALAMA {4} ",
                  ogrencino[index], ogrenciadsoyad[index], vizenotlari[index], finalnotlari[index], ortalama[index]);
                Array.Clear(ogrencino, index, 1);
                Array.Clear(ogrenciadsoyad, index, 1);
                Array.Clear(vizenotlari, index, 1);
                Array.Clear(finalnotlari, index, 1);
                Array.Clear(ortalama, index, 1);
                Console.Write("BAŞKA KAYIT SİLMEK İSTER MİSİNİZ ? (E-H)");
                string devam = Console.ReadLine();
                if (devam=="E")
                {
                    Console.Clear();
                    goto sildevam;
                }
                else
                {
                    Console.Clear();
                    menusecimi();
                }

            }
            else
            {
                Console.WriteLine("{0} NUMARALI ÖĞRENCİ KAYITLI DEĞİLDİR",numara);
                Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN BİR TUŞA BASINIZ.");
                Console.ReadKey();
                Console.Clear();
                menusecimi();
            }
           
        }

        static void kayitara()
        {
            aramadevam:
            Console.WriteLine("*** ÖĞRENCİ KAYIT ARAMA İŞLEMLERİ ***");
            Console.Write("ARAMAK İSTEDİĞİNİZ ÖĞRENCİNİN NUMARASI :");
            string numara = Console.ReadLine();
            int index = Array.IndexOf(ogrencino, numara);
            if (index!= -1)
            {
                Console.WriteLine("ÖĞRENCİ NO : {0} ADI SOYADI : {1} VİZE NOTU : {2} FİNAL NOTU : {3} ORTALAMA {4} ",
                 ogrencino[index], ogrenciadsoyad[index], vizenotlari[index], finalnotlari[index], ortalama[index]);
                Console.Write("BAŞKA KAYIT ARAMAK İSTER MİSİNİZ ? ");
                string devam = Console.ReadLine();
                if (devam=="E")
                {
                    Console.Clear();
                    goto aramadevam;
                }
                else
                {
                    Console.Clear();
                    menusecimi();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("{0} NUMARALI ÖĞRENCİ KAYITLI DEĞİLDİR!",numara);
                Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN BİR TUŞA BASINIZ.");
                Console.ReadKey();
                Console.Clear();
                menusecimi();
            }

        }

        static void kayitlistele()
        {
            bool kayitkontrol = false;
            for (int i = 0; i <ogrencino.Length; i++)
            {
                if (ogrencino[i]!=null)
                {
                    kayitkontrol = true;
                     Console.WriteLine("ÖĞRENCİ NO : {0} ADI SOYADI : {1} VİZE NOTU : {2} FİNAL NOTU : {3} ORTALAMA {4} ",
                  ogrencino[i], ogrenciadsoyad[i], vizenotlari[i], finalnotlari[i], Math.Round(ortalama[i],0));
                }
            }
            if (kayitkontrol==false)
            {
                Console.WriteLine("KAYITLI ÖĞRENCİ BULUNAMADI!");
            }
            Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN BİR TUŞA BASINIZ.");
            Console.ReadKey();
            Console.Clear();
            menusecimi();
        }
    }
}
