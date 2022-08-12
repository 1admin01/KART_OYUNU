using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KART_OYUNU
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            ENBAS:
                int[] secilenSayilar = new int[16];
                string[] harfler = { "A", "A", "B", "B", "C", "C", "D", "D", "E", "E", "F", "F", "G", "G", "H", "H" };
                string[] sayilar = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" };
                string[] degismissayilar = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" };

                int alinan1;
                int alinan2;
                int kontrol = 0;
                int adim = 0;

                DateTime baslama = DateTime.Now;
                Random rnd = new Random();
                for (int i = 0; i < sayilar.Length; i++)
                {
                    Console.Write("|" + sayilar[i]);
                    if (i == 3 || i == 7 || i == 11 || i == 15)
                    {
                        Console.Write("|");
                        Console.WriteLine();

                    }
                }
                for (int i = 0; i < secilenSayilar.Length; i++)
                {
                    secilenSayilar[i] = rnd.Next(0, 16);
                    for (int j = 0; j < i; j++)
                    {
                        if (secilenSayilar[i] == secilenSayilar[j])
                        {
                            i--;
                        }
                    }
                }
                for (int i = 0; i < secilenSayilar.Length; i++)
                {
                    degismissayilar[i] = harfler[secilenSayilar[i]];

                }


            KARTSEC:
                try
                {
                    Console.WriteLine("Lütfen 1.kartı giriniz:");
                    alinan1 = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("GEÇERLİ KART GİRİNİZ");
                    goto KARTSEC;
                }
                string yeni1 = alinan1.ToString();
            KARTSEC2:
                try
                {
                    Console.WriteLine("Lütfen 2.kartı giriniz:");
                    alinan2 = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("GEÇERLİ KART GİRİNİZ");
                    goto KARTSEC2;

                }
                if (alinan1 == alinan2)
                {
                    Console.WriteLine("aynı kartlar girilemez lütfen tekrar deneyerek farklı kartlar giriniz.");
                    goto KARTSEC2;
                }
                string yeni2 = alinan2.ToString();
                string[] yeniler = { yeni1, yeni2 };

                if ((alinan1 <= 16 && alinan1 > 0))
                {

                    for (int i = 0; i < sayilar.Length; i++)
                    {
                        if (sayilar[alinan1 - 1] != yeni1 || sayilar[alinan2 - 1] != yeni2)
                        {
                            Console.WriteLine("açılan değer girilemez.");
                            goto KARTSEC;
                        }
                        if (i == alinan1 - 1 || i == alinan2 - 1)
                        {
                            Console.Write("|" + degismissayilar[i]);

                        }

                        else
                            Console.Write("|" + sayilar[i]);
                        if (i == 3 || i == 7 || i == 11 || i == 15)
                        {
                            Console.Write("|");
                            Console.WriteLine();
                        }


                    }

                    Console.WriteLine("LÜTFEN BİR SONRAKİ ADIM İÇİN ENTER TUŞLAYINIZ.");
                    Console.ReadLine();
                    adim++;


                    if (degismissayilar[alinan1 - 1] == degismissayilar[alinan2 - 1])
                    {

                        Console.Clear();

                        sayilar[alinan1 - 1] = degismissayilar[alinan1 - 1];
                        sayilar[alinan2 - 1] = degismissayilar[alinan2 - 1];
                        for (int i = 0; i < sayilar.Length; i++)
                        {

                            Console.Write("|" + sayilar[i]);
                            if (i == 3 || i == 7 || i == 11 || i == 15)
                            {
                                Console.Write("|");
                                Console.WriteLine();

                            }


                        }


                        kontrol++;
                        DateTime bitis = DateTime.Now;
                        if (kontrol == 8)
                        {

                            Console.WriteLine("OYUN BİTTİ.");
                            Console.WriteLine("TOPLAM ADIM SAYISI:" + adim);
                            Console.WriteLine("TOPLAM OYUN SÜRENİZ:" + (bitis - baslama));


                        YANLIS:
                            Console.WriteLine("TEKRAR OYNAMAK İÇİN 1 E BASINIZ");
                            char a = Convert.ToChar(Console.ReadLine());

                            if (a == '1')
                            {
                                try
                                {

                                    if (a == '1')
                                    {
                                        goto ENBAS;
                                    }

                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("geçerli sayı giriniz.");

                                }

                            }
                            if (a == 0)
                            {
                                try
                                {
                                    if (a == '0')
                                    {
                                        Console.Clear();
                                        Environment.Exit(0);
                                    }
                                }
                                catch (Exception)
                                {

                                    Console.WriteLine("geçerli sayı giriniz.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("yanlış girdiniz.");
                                goto YANLIS;
                            }




                        }
                        goto KARTSEC;
                    }
                    else
                    {
                        Console.Clear();
                        for (int i = 0; i < sayilar.Length; i++)
                        {
                            Console.Write("|" + sayilar[i]);
                            if (i == 3 || i == 7 || i == 11 || i == 15)
                            {
                                Console.Write("|");
                                Console.WriteLine();
                            }
                        }
                        goto KARTSEC;
                    }
                }
                else if ((alinan2 <= 16 && alinan2 > 0))
                {
                    for (int i = 0; i < sayilar.Length; i++)
                    {
                        if (sayilar[alinan1 - 1] != yeni1 || sayilar[alinan2 - 1] != yeni2)
                        {
                            Console.WriteLine("açılan değer girilemez.");
                            goto KARTSEC;
                        }
                        if (i == alinan1 - 1 || i == alinan2 - 1)
                        {
                            Console.Write("|" + degismissayilar[i]);

                        }

                        else
                            Console.Write("|" + sayilar[i]);
                        if (i == 3 || i == 7 || i == 11 || i == 15)
                        {
                            Console.Write("|");
                            Console.WriteLine();
                        }


                    }

                    Console.WriteLine("LÜTFEN BİR SONRAKİ ADIM İÇİN ENTER TUŞLAYINIZ.");
                    Console.ReadLine();
                    adim++;


                    if (degismissayilar[alinan1 - 1] == degismissayilar[alinan2 - 1])
                    {

                        Console.Clear();
                        sayilar[alinan1 - 1] = degismissayilar[alinan1 - 1];
                        sayilar[alinan2 - 1] = degismissayilar[alinan2 - 1];
                        for (int i = 0; i < sayilar.Length; i++)
                        {


                            Console.Write("|" + sayilar[i]);
                            if (i == 3 || i == 7 || i == 11 || i == 15)
                            {
                                Console.Write("|");
                                Console.WriteLine();

                            }


                        }


                        kontrol++;
                        DateTime bitiş = DateTime.Now;
                        if (kontrol == 8)
                        {

                            Console.WriteLine("OYUN BİTTİ.");
                            Console.WriteLine("TOPLAM ADIM SAYISI:" + adim);
                            Console.WriteLine("TOPLAM OYUN SÜRENİZ:" + (bitiş - baslama));


                        YANLIS:
                            Console.WriteLine("TEKRAR OYNAMAK İÇİN 1 E BASINIZ");
                            Console.WriteLine("ÇIKIŞ YAPMAK İÇİN 0 A BASINIZ.");
                            char a = Convert.ToChar(Console.ReadLine());

                            if (a == '1')
                            {
                                try
                                {

                                    if (a == '1')
                                    {
                                        goto ENBAS;
                                    }

                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("geçerli sayı giriniz.");

                                }

                            }
                            if (a==0)
                            {
                                try
                                {
                                    if (a=='0')
                                    {
                                        Console.Clear();
                                        Environment.Exit(0);
                                    }
                                }
                                catch (Exception)
                                {

                                    Console.WriteLine("geçerli sayı giriniz.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("yanlış girdiniz.");
                                goto YANLIS;
                            }




                        }
                        goto KARTSEC2;
                    }
                    else
                    {
                        Console.Clear();
                        for (int i = 0; i < sayilar.Length; i++)
                        {
                            Console.Write("|" + sayilar[i]);
                            if (i == 3 || i == 7 || i == 11 || i == 15)
                            {
                                Console.Write("|");
                                Console.WriteLine();
                            }
                        }
                        goto KARTSEC2;
                    }
                }
                else
                {
                    Console.WriteLine("GEÇERLİ KART GİRİNİZ");
                    goto KARTSEC;
                }
            }
        }
    }
}
