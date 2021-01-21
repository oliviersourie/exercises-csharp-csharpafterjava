using ClassLib;
using ClassLib.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Computers pcs = new Computers()
            {
                new Laptop { Brand = "Dell", DeviceColor = Color.Black },
                new Laptop { Brand = "Lenovo", DeviceColor = Color.Black},
                new Desktop { Brand = "Asus", DeviceColor = Color.Transparant }
            };

            foreach (Computer pc in pcs)
            {
                Console.WriteLine(pc);
            }
        }
    }

    class Computers : IEnumerable<Computer>
    {
        public List<Computer> ComputerList { get; set; }

        public Computers()
        {
            ComputerList = new();
        }

        public void Add(Computer computer)
        {
            ComputerList.Add(computer);
        }

        public IEnumerator<Computer> GetEnumerator()
        {
            return ComputerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
