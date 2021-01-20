using System;
using System.Collections;

namespace KaprekarSayisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, tpl = 0;
            ArrayList ar = new ArrayList();
            for (long x = 9; x <= 1000000; x++)
            {
                long sayi = x * x;
                if (sayi.ToString().Length % 2 == 0 || sayi.ToString().Length % 2 == 1)
                {
                    int bolum = sayi.ToString().Length / 2;
                    if (sayi.ToString().Length % 2 == 1)
                    {
                        int k = 0;
                        for (int j = 0; j <= sayi.ToString().Length; j = j + bolum)
                        {
                            if (k == 2)
                            {
                                a = Convert.ToInt32(sayi.ToString().Substring(j, bolum + 1));
                                tpl += a;
                                k = 1;
                            }

                            else if (k == 0)
                            {

                                a = Convert.ToInt32(sayi.ToString().Substring(j, bolum));
                                tpl += a;
                                k += 2;
                            }

                        }
                    }
                    else
                    {
                        for (int i = 0; i < sayi.ToString().Length; i = i + bolum)
                        {
                            a = Convert.ToInt32(sayi.ToString().Substring(i, bolum));
                            tpl += a;
                        }
                    }

                    if (x == tpl)
                    {
                        ar.Add(x);
                    }
                    tpl = 0;
                }
            }
            Console.WriteLine("kaprekar sayıları");
            foreach (var y in ar)
            {
                Console.WriteLine(y);
            }
        }
    }
}
