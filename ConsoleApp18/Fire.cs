using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Fire
    {
        public int Capacitybullet;
        public int Currentbullet;
        public bool Firemode;
        public int Capacity2;

        
        
        public Fire(int capacityBullet, int currentBullet, bool fireMode)
        {
            Capacitybullet = capacityBullet;
            Currentbullet = currentBullet;
            Firemode = fireMode;
        }

        public void Shoot()
        {
            if (Currentbullet > 0)
            {
                if (Firemode=true) 
                {
                    Currentbullet = 0;
                    Console.WriteLine("butun gulleler ateslendi");

                }
                else 
                {
                   
                    Currentbullet--;
                    Console.WriteLine("tek gulle atildi");
                }
            }
            else
            {
                Console.WriteLine("Gulle yoxdur!");
            }
        }


        public void Getremainbulletcount() {


            Console.WriteLine("daraq ucun lazim olan gulle sayi");
            Console.WriteLine( Capacitybullet - Currentbullet);
        
        
        }
        public void Reload ( )
        {
            Capacitybullet = Currentbullet;
            Console.WriteLine("daraq reload oldu");


        }
        public void Changefirmode()
        {
            if (Firemode = true)
            {
                Firemode = false;
            }
            else {Firemode = true;}
        }
        public void Showfullinfo()
        {
            Console.WriteLine($"Daragin gulle tutumu:{Capacitybullet},Daragdaki gulle sayi:{Currentbullet}");
        }



    }
   


}
