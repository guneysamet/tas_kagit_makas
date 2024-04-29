using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            string secim;
            string tas = "";
            string kagit = "";
            string makas = "";
            Random r= new Random();
            int bakiye=r.Next(50,100);
            Console.WriteLine("oyun : taş kağıt makas\n");
            Console.WriteLine("iddia = -5 $");
            Console.WriteLine("beraberlik durumu : +5 $");
            Console.WriteLine("kazanç durumu = +10 $");
            while (bakiye>=5)
            {
                Console.WriteLine("bakiye : " + bakiye + "$\n");
                Console.Write("seçim : ");
                secim = Console.ReadLine();
                secim = secim.ToLower().Trim();
                while (secim != "taş" && secim != "makas" && secim != "kağıt")
                {
                    Console.WriteLine("\n'taş','kağıt' ya da 'makas' girmelisin!\n");
                    Console.Write("seçim : ");
                    secim = Console.ReadLine();
                    secim = secim.ToLower().Trim();
                }
                bakiye -= 5;
                Random r2 = new Random();
                int pc = r2.Next(1, 4);
                if (pc == 1)
                {
                    tas = "taş";
                }
                if (pc == 2)
                {
                    kagit = "kağıt";
                }
                if (pc == 3)
                {
                    makas = "makas";
                }
                string tkm = tas + kagit + makas;
                if (sayac % 3 == 0)
                {
                    if (secim=="taş")
                    {
                        tkm = "kağıt";
                    }
                    else if (secim=="kağıt")
                    {
                        tkm = "makas";
                    }
                    else if (secim=="makas")
                    {
                        tkm = "taş";
                    }
                }
                Console.WriteLine("pc : " + tkm);
                if (secim == tkm)
                {
                    bakiye += 5;
                }
                else if (secim=="taş"&&tkm=="makas")
                {
                    bakiye += 10;
                }
                else if (secim == "kağıt" && tkm == "taş")
                {
                    bakiye += 10;
                }
                else if (secim == "makas" && tkm == "kağıt")
                {
                    bakiye += 10;
                }
                tkm = "";
                tas = "";
                kagit = "";
                makas = "";
                sayac++;
                Console.WriteLine();
            }
            Console.WriteLine("paran bitti!");
            Console.ReadLine();
        }
    }
}
