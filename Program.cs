using System;

namespace homework12
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            One();
            Two();
            Three();
            Four();
            Five();
            Six();
            Seven();
            Eight();
            Nine();

        }
        static void One()
        {
            #region Task1

            //try
            //{
            //    int a, b, c;
            //    Console.WriteLine(" Birinci ededi daxil edin");
            //    a = int.Parse(Console.ReadLine());
            //    Console.WriteLine(" Ikinci ededi daxil edin");
            //    b = int.Parse(Console.ReadLine());
            //    Console.WriteLine(" Uçuncu ededi daxil edin");
            //    c = int.Parse(Console.ReadLine());

            //    if (a > b)
            //    {

            //        if (a > c)

            //        {
            //            Console.WriteLine(" En boyuk eded Birinci : " + a);
            //        }

            //        else
            //        {
            //            Console.WriteLine(" En boyuk eded Uçuncu : " + c);
            //        }
            //    }
            //    else
            //    {

            //        if (b > c)
            //        {
            //            Console.WriteLine(" En boyuk eded Ikinci : " + b);
            //        }
            //        else
            //        {
            //            Console.WriteLine(" En boyuk eded Uçuncu : " + c);
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine(" Duzgun Deyer Daxil Edin ");
            //}




            #endregion

        }
        static void Two()
        {
            #region Task2
            //try
            //{
            //    int a, b, c, d, e, avg, sum;
            //    Console.WriteLine(" 5 eded daxil edin:");
            //    a = int.Parse(Console.ReadLine());
            //    b = int.Parse(Console.ReadLine());
            //    c = int.Parse(Console.ReadLine());
            //    d = int.Parse(Console.ReadLine());
            //    e = int.Parse(Console.ReadLine());
            //    sum = (a + b + c + d + e);
            //    avg = (sum / 5);
            //    Console.WriteLine("Sum :" + sum);
            //    Console.WriteLine("Average :" + avg);
            //    Console.ReadLine();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine(" Duzgun Deyer Daxil Edin ");
            //}


            #endregion

        }
        static void Three()
        {
            #region Task3
            //try
            //{
            //    int uzunluq, en;
            //    Console.WriteLine("Düzbucaqlının enini daxil edin:");
            //    en = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Düzbucaqlının hündürlüyünü daxil edin:");
            //    uzunluq = int.Parse(Console.ReadLine());

            //    int sahe = uzunluq * en;
            //    int perimetir = 2 * (uzunluq + en);

            //    Console.WriteLine("sahe: {0}", sahe);
            //    Console.WriteLine("perimetir: {0}", perimetir);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine(" Duzgun Deyer Daxil Edin ");
            //}


            #endregion

        }
        static void Four()
        {
            #region Task4
            //try
            //{
            //    int a, i, count = 0;
            //    Console.WriteLine(" Birinci ededi daxil edin");
            //    a = int.Parse(Console.ReadLine());
            //    Console.WriteLine(" Ikinci ededi daxil edin");
            //    i = int.Parse(Console.ReadLine());
            //    if (a > 1)

            //    {
            //        while (i <= a)
            //        {
            //            if (a % i == 0)

            //            {
            //                count++;
            //                i++;
            //            }
            //            else
            //            {
            //                i++;
            //            }

            //        }
            //        if (count > 2)
            //        {
            //            Console.WriteLine("Eded Murekkebdir");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Eded Sadedir");
            //        }

            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine(" Duzgun Deyer Daxil Edin ");
            //}


            #endregion
        }
        static void Five()
        {

            #region Task5


            //try
            //{

            //    Console.WriteLine("Reqem Daxil Edin");

            //    int num = int.Parse(Console.ReadLine());
            //    int sum = 0;
            //    while (num > 0)
            //    {

            //        num = num / 10;
            //        sum++;
            //    }

            //    Console.WriteLine("Mertebelerin Sayı = {0}", sum);

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine(" Herf Daxil Etmeyin ");
            //}

            #endregion
        }
        static void Six()
        {
            #region Task6
            //try
            //{
            //    Console.WriteLine(" Eded Daxil Edin ");
            //    int a = int.Parse(Console.ReadLine());

            //    if (a > 1 && a % 21 == 0)
            //    {
            //        Console.WriteLine(" Eded Hem 3-e Hemde 7-e Bolunur ");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Deyer Duzgun Deyil");
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine(" Herf Daxil Etmeyin");
            //}

            #endregion
        }
        static void Seven()
        {
            #region Task7
            //Console.WriteLine(" Qiymetini Daxil Et ");
            //try
            //{
            //    byte num = byte.Parse(Console.ReadLine());
            //    if (num >= 1 && num <= 100)

            //    {
            //        if (num >= 91 && num <= 100)
            //            Console.WriteLine(" A ");
            //        {
            //            if (num >= 81 && num <= 90)
            //                Console.WriteLine(" B ");
            //            {
            //                if (num >= 71 && num <= 80)
            //                    Console.WriteLine(" C ");
            //                {
            //                    if (num >= 61 && num <= 70)
            //                        Console.WriteLine(" D ");
            //                    {
            //                        if (num >= 51 && num <= 60)
            //                            Console.WriteLine(" E ");
            //                        {
            //                            if (num >= 0 && num <= 51)
            //                                Console.WriteLine("Kesildiniz");
            //                            {

            //                            }

            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine(" Daxil Etdiyiniz Reqem 1-ile 100-arasında olmalıdır. ");

            //}
            #endregion

        }
        static void Eight()
        {
            #region Task8
            //try
            //{
            //    Console.WriteLine("Birinci Ededi Daxil Et");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Ikinci Ededi Daxil Et");
            //    int b = int.Parse(Console.ReadLine());
            //    int min = 0;
            //    int max = 0;
            //    int result = 0;
            //    if (a != b)
            //    {
            //        if (a > b)
            //        {
            //            min = b;
            //            max = a;
            //        }
            //        else
            //        {
            //            min = a;
            //            max = b;
            //        }


            //        while (min <= max)
            //        {
            //            result += min;
            //            min++;
            //        }
            //        Console.WriteLine(" Cavab " + result);
            //    }

            //}
            //catch (FormatException)
            //{

            //    Console.WriteLine("Herf Daxil Etmek Olmaz!");
            //}
            #endregion



        }
        static void Nine()
        {
            #region Task9
            //try
            //{
            //    int n, m;
            //    int result = 1;
            //    Console.Write("n deyerini daxil edin :");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("m deyerini daxil edin :");
            //    m = Convert.ToInt32(Console.ReadLine());
            //    if (m > 0)
            //    {
            //        for (int i = m; i > 0; i--)
            //            result = result * n;
            //    }
            //    else if (m < 0)
            //    {
            //        for (int i = m; i < 0; i++)
            //            result = result / n;
            //    }

            //    Console.WriteLine("{0} {1} Cavab {2}", n, m, result);

            //    Console.ReadKey();
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine(" Herf Daxil Etmek Olmaz! ");

            //}
            #endregion
        }
    }
}
