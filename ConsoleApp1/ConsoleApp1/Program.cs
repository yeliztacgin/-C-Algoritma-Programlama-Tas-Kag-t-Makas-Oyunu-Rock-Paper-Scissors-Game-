using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///1.Tas
            ///2.Kagıt
            ///3.Makas
            ///
            ///kullanıcı :1  pc:3  win
            ///kullanıcı :1  pc:2  lose
            ///kullanıcı :1  pc:1  berabere
            /// ///
            ///kullanıcı :2  pc:3  lose
            ///kullanıcı :2  pc:2  berabere
            ///kullanıcı :2  pc:1  win
            /// ///
            ///kullanıcı :3  pc:3  berabere
            ///kullanıcı :3  pc:2  win
            ///kullanıcı :3  pc:1  lose
            ///


            Random rastgele = new Random();

            int bCevap=rastgele.Next(1,4);

            Console.WriteLine("Tas Kagıt Makas Oyununa Hosgeldin\n1.Tas\n2.Kagıt\n3.Makas");
            
            int kCevap = int.Parse(Console.ReadLine());
           
            if( (kCevap == 1 && bCevap == 3)|| (kCevap == 2 && bCevap == 1) || (kCevap == 3 && bCevap == 2))
            {
                Console.WriteLine("Tebrikler kazandınız\n"+bCevap);
            }
            else if((kCevap == 1 && bCevap == 1) || (kCevap == 2 && bCevap == 2) || (kCevap == 3 && bCevap == 3))
            {
                Console.WriteLine("Berabere\n"+bCevap);

            }
            else
            {
                Console.WriteLine("Kaybettiniz\n"+bCevap);
            }
            
            
            Console.ReadLine();
        
        }


    }
}
