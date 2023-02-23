using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   class Program
   {
        static void Main()
        {
            for(; ; )
            { 
            Console.WriteLine("Bir metin giriniz:");
            string metin = Console.ReadLine();
            for(int i=0;i<metin.Length;i++)
            {
                char x = Convert.ToChar(metin[i]);
                int y = Convert.ToChar(x);
                if(y<=64||(y>=91&&y<=96)||y>=123)
                {
                    Console.WriteLine("Metindeki karakterleriniz harflerden oluşmamaktadır.Yeni bir metin giriniz.");
                    metin = Console.ReadLine();
                    
                    }
                else
                {
                        Sifrele_ve_Sifre_coz nesne = new Sifrele_ve_Sifre_coz(metin);
                        nesne.Bilgi();
                        break;
                }
            }
            }
            
            
        }
   }
    class Sifrele_ve_Sifre_coz
    {
        private string metin1;
        
        public Sifrele_ve_Sifre_coz(string metin)
        {
            metin1 = metin;  
        }
        public string kriptoloji
        {
            set
            {
                metin1 = value;
            }
            get
            {
                return metin1;
            }
        }
        
        public string Sifrele()
        {
            string toplam = "";
            for (int i=0;i<metin1.Length;i++)
            {
                int a = Convert.ToInt32(metin1[i]);
                a++;
                char b = Convert.ToChar(a);
                string c = Convert.ToString(b); 
                toplam = toplam + c; 
            }
            return toplam;
        }
        public string Sifre_coz(string toplam)
        {
            string toplam2 = "";
            for (int i = 0; i < toplam.Length; i++)
            {
               char n=Convert.ToChar(toplam[i]);   
                int k = Convert.ToInt32(n);
                k=k-1;
                char l = Convert.ToChar(k);
                string m = Convert.ToString(l);
                toplam2 = toplam2 + m;
            }
            return toplam2;
        }

        public void Bilgi ()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Metnin şifrelenmiş hali : {0} ",Sifrele());
            Console.WriteLine("Metnin şifresinin çözülmüş hali : {0} ", Sifre_coz(Sifrele()));
        }
        
    }
}
