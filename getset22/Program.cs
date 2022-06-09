using System;

namespace getset22
{
    class Program
    {
        static void Main(string[] args)


        {
            Computer computer = new Computer("HP", "3,5 GHz", "16", "1000", "3", "17,3", "Desktop", "No", 679, 999);


            Console.WriteLine("Manufacturer: " + computer.Manufacturer);
            Console.WriteLine("Processor speed: " + computer.Speed);
            Console.WriteLine("Memory in Gigabytes: " + computer.Gigabytes);
            Console.WriteLine("Hard Disk size in gigabytes: " + computer.HardDisk);
            Console.WriteLine("Number of USB ports: " + computer.Usb);
            Console.WriteLine("Screen size in inches: " + computer.Screen);
            Console.WriteLine("Computer type: " + computer.Type);
            Console.WriteLine("Pre-installed operating system yes/no: " + computer.preSystem);
            Console.WriteLine("Purchase price: " + computer.Purchase);
            Console.WriteLine("Sale price: " + computer.SalePrice);

            Console.WriteLine("---------------------------------------------");

            Computer computerTwo = new Computer("Apple", "4,2GHz", "8", "500", "2", "14", "Laptop", "Yes", 889, 1299);
            
   
          
            Console.WriteLine("Manufacturer: " + computerTwo.Manufacturer);
            Console.WriteLine("Processor speed: " + computerTwo.Speed);
            Console.WriteLine("Memory in Gigabytes: " + computerTwo.Gigabytes);
            Console.WriteLine("Hard Disk size in gigabytes: " + computerTwo.HardDisk);
            Console.WriteLine("Number of USB ports: " + computerTwo.Usb);
            Console.WriteLine("Screen size in inches: " + computerTwo.Screen);
            Console.WriteLine("Computer type: " + computerTwo.Type);
            Console.WriteLine("Pre-installed operating system yes/no: " + computerTwo.preSystem);
            Console.WriteLine("Purchase price: " + computerTwo.Purchase);
            Console.WriteLine("Sale price: " + computerTwo.SalePrice);
            Console.ReadKey();

            /*for (int i = 0; i < 1; i++)
                {
                Console.WriteLine("HALOO");
            }*/
        }
    }

    class Computer
    {
      
       public string Manufacturer { get; set; }
       public string Speed { get; set; }
       public string Gigabytes { get; set; }
       public string HardDisk { get; set; }
       public string Usb { get; set; }
       public string Screen { get; set; }
       public string Type { get; set; }
       public string preSystem { get; set; }
       public int Purchase { get; set; }
       public int SalePrice { get; set; }
       
        public Computer(string aManufacturer, string aSpeed, string aGigabytes, string aHardDisk, string aUsb, string aScreen, string aType, string apreSystem, int aPurchase, int aSalePrice)
        {
            Manufacturer = aManufacturer;
            Speed = aSpeed;
            Gigabytes = aGigabytes;
            HardDisk = aHardDisk;
            Usb = aUsb;
            Screen = aScreen;
            Type = aType;
            preSystem = apreSystem;
            Purchase = aPurchase;
            SalePrice = aSalePrice;

            
        }
        
        
        }
    }

