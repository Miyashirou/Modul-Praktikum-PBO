using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tugasgasgas;

namespace tugasgasgas
{
    class Laptop
    {
        public string merkLaptop, tipeLaptop;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merkLaptop} {tipeLaptop} dinyalakan");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merkLaptop} {tipeLaptop} dimatikan");
        }
    }

    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merkLaptop = "ASUS";
        }
    }

    class ROG : ASUS
    {
        public ROG()
        {
            base.tipeLaptop = "ROG";
        }
    }

    class Vivobook : Laptop
    {
        public Vivobook()
        {
            base.tipeLaptop = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ngoding in progress eh malah ngecresh");
        }
    }

    class ACER : Laptop
    {
        public ACER()
        {
            base.merkLaptop = "ACER";
        }
    }

    class Predator : ACER
    {
        public Predator()
        {
            base.tipeLaptop = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merkLaptop} {tipeLaptop} sedang memainkan game");
        }
    }

    class Swift : ACER
    {
        public Swift()
        {
            base.tipeLaptop = "Swift";
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merkLaptop = "Lenovo";
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipeLaptop = "IdeaPad";
        }
    }

    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipeLaptop = "Legion";
        }
    }
    class Vga
    {
        public string merk;
    }
    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }

    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }


    class Processor
    {
        public string merk, tipe;
    }

    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }

    class amd : Processor
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }

    class Ryzen : amd
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }

    class Athlon : amd
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();

            Laptop laptop2 = new IdeaPad();
            laptop2.vga = new AMD();
            laptop2.processor = new Ryzen();

            Predator predator = new Predator();
            predator.vga = new Nvidia();
            predator.processor = new CoreI7();

            ACER acer = new Predator();
            
            //acer.Bermaingame();

            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            Console.WriteLine(" \r\n");

            Console.WriteLine("===== LAPTOP 1 =====");
            Console.WriteLine("VGA              :" + laptop1.vga.merk);
            Console.WriteLine("Merk Processor   :" + laptop1.processor.merk);
            Console.WriteLine("Tipe Processor   :" + laptop1.processor.tipe);

            Console.WriteLine("\r\n");

            predator.BermainGame();

            

            //laptop1.Ngoding();
        }
    }
}
