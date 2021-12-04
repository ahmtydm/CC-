using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmetydrm

{
    class Program
    {
        static void Main(string[] args)
        {
            int soru;
            Console.WriteLine("Bir Soru Giriniz...");
            soru = Convert.ToInt32(Console.ReadLine());
            switch (soru)
            {
                case 1:
                    double sayı1, sayı2, ortalama;
                    Console.WriteLine("1. Sayı Giriniz....");
                    sayı1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("2.sayıyı Giriniz....");
                    sayı2 = Convert.ToDouble(Console.ReadLine());

                    ortalama = (sayı1 + sayı2) / 2;

                    Console.WriteLine("ortalama  " + ortalama);
                    Console.ReadKey();
                    break;


                case 2:

                    double x;

                    Console.WriteLine("Bir Sayı Giriniz...");
                    x = Convert.ToInt32(Console.ReadLine());

                    {

                        if (x < 0)

                            Console.WriteLine("Sayı Negatıf");


                        else

                            Console.WriteLine("Sayı Pozitif");

                        Console.ReadKey();

                        break;

                    }

                case 3:

                    double KU, H, alan;

                    Console.WriteLine("Bir Kenar Uzunluğu Giriniz");

                    KU = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Yüksekliği Giriniz");

                    H = Convert.ToDouble(Console.ReadLine());

                    alan = (KU * H) / 2;

                    Console.WriteLine("alan  " + alan);

                    Console.ReadKey();

                    break;


                case 4:

                    double v, h;

                    Console.WriteLine("Bir Sayı Giriniz");

                    v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Bir Sayı Daha Giriniz");

                    h = Convert.ToDouble(Console.ReadLine());

                    {
                        if (v < h)

                            Console.WriteLine("1.sayı ,2sayıdan küçüktür");



                        else
                            Console.WriteLine("2.sayı,1sayıdan büyüktür");

                        Console.ReadKey();

                        break;

                    }

                case 5:

                    double vize, final, ort;

                    Console.WriteLine("Vize Notunuzu Giriniz");
                    vize = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Final Notunuzu Giriniz");
                    final = Convert.ToDouble(Console.ReadLine());
                    ort = Convert.ToDouble(vize * 0.3 + final * 0.7);

                    Console.WriteLine("Sınavlarınızın Ortalaması... " + ort);
                    Console.ReadKey();
                    break;

                case 6:

                    double pi = 3.14, r;

                    Console.WriteLine("Dairenin Yarıçapı Giriniz");
                    r = Convert.ToDouble(Console.ReadLine());
                    double aln = (pi * r * r);

                    Console.WriteLine("Dairenin alanı  " + aln);

                    double çevre = (2 * pi * r);
                    Console.WriteLine("Dairenin Çevresi  " + çevre);

                    Console.ReadKey();
                    break;

                case 7:
                    int sy1, sy2, sy3, sy4, sy5, sy6, sy7, sy8, sy9, sy10;

                    Console.WriteLine("Klavyeden Bir Sayı Giriniz");
                    sy1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Klavyeden Bir Sayı Giriniz");
                    sy2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Klavyeden Bir Sayı Giriniz");
                    sy3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Klavyeden Bir Sayı Giriniz");
                    sy4 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Klavyeden Bir Sayı Giriniz");
                    sy5 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Klavyeden Bir Sayı Giriniz");
                    sy6 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Klavyeden Bir Sayı Giriniz");
                    sy7 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Klavyeden Bir Sayı Giriniz");
                    sy8 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Klavyeden Bir Sayı Giriniz");
                    sy9 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Klavyeden Bir Sayı Giriniz");
                    sy10 = Convert.ToInt32(Console.ReadLine());

                    if (sy1 > 50)
                    {
                        Console.WriteLine(sy1);


                    }
                    else if (sy2 > 50)
                    {
                        Console.WriteLine(sy2);


                    }
                    else if (sy3 > 50)
                    {
                        Console.WriteLine(sy3);


                    }
                    else if (sy4 > 50)
                    {
                        Console.WriteLine(sy4);


                    }
                    else if (sy5 > 50)
                    {
                        Console.WriteLine(sy5);


                    }
                    else if (sy6 > 50)
                    {
                        Console.WriteLine(sy6);


                    }
                    else if (sy7 > 50)
                    {
                        Console.WriteLine(sy7);


                    }
                    else if (sy8 > 50)
                    {
                        Console.WriteLine(sy8);


                    }
                    else if (sy9 > 50)
                    {
                        Console.WriteLine(sy9);


                    }
                    else if (sy10 > 50)
                    {
                        Console.WriteLine(sy10);


                    }
                    Console.ReadKey();
                    break;

                case 8:

                    double sayı = 0, sayac = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(" sayıyı giriniz:");



                        sayı =
                        Convert.ToDouble(Console.ReadLine());

                        if (sayı > 100)
                        {
                            sayac++;

                        }

                        Console.WriteLine("100 den büyük  adet sayıyı giriniz", sayac);
                        Console.ReadKey();

                    }

                    break;

                case 9:
                    Console.WriteLine("sayı giriniz");
                    int sa = int.Parse(Console.ReadLine());
                    int toplam = 0;
                    int sayacc = 0;
                    while (sa != 0)
                    {
                        sayacc++;
                        toplam += sa;
                        Console.WriteLine("sayı giriniz");
                        sa = int.Parse(Console.ReadLine());

                    }
                    Console.WriteLine("Toplam " + toplam);
                    {
                        int orta = toplam / sayacc;
                        Console.WriteLine("Ortalama " + orta);

                    }


                    Console.ReadKey();
                    break;
                case 10:

                    double not1, not2, not3, orti;

                    Console.WriteLine("1.notunuzu giriniz");

                    not1 = Convert.ToDouble(Console.ReadLine());
                    if (not1 < 0 || not1 > 100) ;
                    { Console.WriteLine("Yanlış not girdiniz..."); }
                    Console.WriteLine("2.notunuzu giriniz");
                    not2 = Convert.ToDouble(Console.ReadLine());
                    if (not2 < 0 || not2 > 100) ;
                    { Console.WriteLine("Yanlış not girdiniz..."); }
                    Console.WriteLine("3.notunuzu giriniz");
                    not3 = Convert.ToDouble(Console.ReadLine());
                    if (not3 < 0 || not3 > 100) ;
                    { Console.WriteLine("Yanlış not girdiniz..."); }
                    orti = (not1 + not2 + not3) / 3;

                    Console.Write("ortalamanız: {0}", orti);
                    Console.ReadKey();
                    break;



                case 11:

                    int say;

                    for (int i = 1; i <= 1000; i++)
                    {

                        Console.WriteLine(i);


                    }

                    Console.ReadKey();

                    break;

                case 12:

                    int xx;

                    Console.WriteLine("Sayı Giriniz");
                    xx = Convert.ToInt32(Console.ReadLine());

                    if (xx >= 0 && xx <= 100)
                    {
                        Console.WriteLine("sayı 0 ile 100 arasındadır ");

                    }
                    else
                    {
                        Console.WriteLine("sayı 0 ile 100 arasında değil");
                    }
                    Console.ReadKey();
                    break;


                case 13:


                    int toplam23 = 0, n;
                    Console.WriteLine("n sayısını giriniz");
                    n = Convert.ToInt32(Console.ReadLine());


                    for (int i = 1; i <= n; i++)
                    {

                        toplam23 += i;

                    }

                    Console.WriteLine("birden n e kadar olan sayıların toplamı {0}'dir..", toplam23);

                    Console.ReadKey();
                    break;

                case 14:


                    double not11, not22, not33, otr;

                    Console.WriteLine("1.notunuzu giriniz");
                    not11 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("2.notunuzu giriniz");
                    not22 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("3.notunuzu giriniz");
                    not33 = Convert.ToDouble(Console.ReadLine());

                    otr = (not11 + not22 + not33) / 3;
                    if (not11 <= 0 && not22 <= 0 && not33 <= 0 && not11 >= 100 && not22 >= 100 && not33 >= 100)
                    {
                        Console.Write("0 ile 100 arasında sayı giriniz");
                    }





                    Console.WriteLine("ortalamız " + otr);
                    Console.ReadKey();
                    break;

                case 15:



                    Console.WriteLine("derece değeri giriniz");
                    double derece = Convert.ToDouble(Console.ReadLine());
                    double radyan = derece * Math.PI / 180;
                    double grad = (derece / 400) * 360;
                    Console.WriteLine(" {0} Derece  Radyan {1} Grad  " + derece, radyan, grad);


                    Console.ReadKey();
                    break;

                case 16:

                    int sayy;

                    Console.WriteLine("Bir sayı Giriniz..");
                    sayy = Convert.ToInt32(Console.ReadLine());
                    if (sayy % 2 == 0)
                    {
                        Console.WriteLine("{0} Sayı Çiftir ", sayy);
                    }

                    else
                    {
                        Console.WriteLine("{0} Sayı tektir", sayy);

                    }
                    Console.ReadKey();
                    break;

                case 17:

                    int saa;

                    Console.WriteLine("Bir sayı giriniz");
                    int.TryParse(Console.ReadLine(), out saa);

                    int mutlak = Math.Abs(saa);

                    Console.WriteLine("Girilen sayının mutlak değeri  " + mutlak);
                    Console.ReadKey();
                    break;

                case 18:

                    int a, b;

                    Console.WriteLine("X sayısını giriniz");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Y sayısını giriniz");
                    b = Convert.ToInt32(Console.ReadLine());

                    if (a % b == 0)
                    {

                        Console.WriteLine("x ve y tam bölünür");

                    }
                    else
                    {
                        Console.WriteLine("x ve y tam bölünmez");

                    }
                    Console.ReadKey();
                    break;


                case 19:

                    Console.Write("Sayı giriniz ---> ");
                    int sayyii = Convert.ToInt32(Console.ReadLine());
                    int toplim = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i <= sayyii; i++)
                    {
                        if (i % 2 == 0)
                            toplam = +i;
                    }
                    Console.WriteLine(sayyii + " sayısına kadar çift sayıların toplamı: " + toplim);
                    break;

                case 20:

                    int kök;
                    Console.WriteLine("A değerini giriniz");
                    int AA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("B değerini giriniz");
                    int BB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("C değerini giriniz");
                    int CC = Convert.ToInt32(Console.ReadLine());
                    kök = (CC - BB) / AA;
                    Console.WriteLine("Kök " + kök);
                    Console.Read();
                    break;

                case 21:
                    Console.WriteLine("A değerini giriniz");
                    int A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("B değerini giriniz");
                    int B = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("C değerini giriniz");
                    int C = Convert.ToInt32(Console.ReadLine());
                    double d = (B * B) - (4 * A * C);
                    if (d > 0)
                    {
                        double x1 = ((-B - Math.Sqrt(d))) / (2 * A);
                        double x2 = ((-B - Math.Sqrt(d))) / (2 * A);
                        Console.WriteLine("Denklemin iki kökü vardır=");
                        Console.WriteLine("x1 =" + x1);
                        Console.WriteLine("x2" + x2);


                    }

                    else if (d == 0)
                    {
                        double z = -B / (2 - A);
                        Console.WriteLine("Denklemin bir kökü vardır...");
                        Console.WriteLine("z =" + z);
                    }


                    else
                    {
                        Console.WriteLine("sanal kök vardır");

                    }
                    Console.ReadKey();
                    break;

                case 22:

                    Console.Write("Kilo Değerini Giriniz =");
                    int kilo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Boy Değerini Gİriniz =");
                    int boy = Convert.ToInt32(Console.ReadLine());
                    double oran = boy / kilo;
                    if (oran < 18.5)
                    { Console.WriteLine("Zayıf"); }
                    else if (oran > 18.5 && oran < 24.9)
                    { Console.WriteLine("Normal"); }
                    else if (oran > 25 && oran < 29.9)
                    { Console.WriteLine("Fazla kilolu"); }
                    else if (oran > 30 && oran < 34.9)
                    { Console.WriteLine("1.Dereceden obez"); }
                    else if (oran > 35 && oran < 39.9)
                    { Console.WriteLine("2.Dereceden obez"); }
                    else
                    { Console.WriteLine("3.Dereceden obez"); }
                    Console.ReadKey();
                    break;
                case 23:
                    int saat, çalışmasaati;
                    Console.WriteLine("çalıştığı saatini giriniz****");
                    saat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("çocuk sayısını giriniz****");
                    çalışmasaati = Convert.ToInt32(Console.ReadLine());
                    if (saat < 40)
                    {
                        int maaş = saat * çalışmasaati;
                        Console.WriteLine("maaş =" + maaş);

                    }
                    else
                    {
                        Console.WriteLine("hatta");
                    }
                    Console.ReadKey();
                    break;

                case 24:

                    Console.WriteLine("Tam sayı giriniz:");
                    int rakam;
                    rakam = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= rakam; i++)
                    {
                        if (rakam % i == 0)

                        {
                            Console.WriteLine(i + "-");

                        }

                    }

                    Console.ReadLine();
                    break;

                case 25:

                    Console.Write("Sayıyı Giriniz =");
                    double sy = Convert.ToDouble(Console.ReadLine());
                    double faktöriyel = 1;
                    for (double i = sy; i >= 2; i--)
                    {
                        faktöriyel *= i;

                    }
                    Console.WriteLine("{0} sayısının faktöriyeli={1} ", sy, faktöriyel);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
